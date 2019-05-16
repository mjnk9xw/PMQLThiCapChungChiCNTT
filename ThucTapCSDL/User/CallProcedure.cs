using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class CallProcedure
    {
        private SqlConnection conn = new SqlConnection("data source=.\\SQLEXPRESS;database=ThucTap_CSDL;integrated security=true");

        // call 1 procedure muốn lấy nhiều colum
        public List<List<string>> GetDataProcedureSimple(string procedureName, string[] columName )
        {
            List<List<string>> resp = new List<List<string>>();
            for(int i = 0; i < columName.Length; i++)
            {
                resp.Add(new List<string>());
            }

            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            { 
                for (int i = 0; i < columName.Length; i++)
                {
                    resp[i].Add(rd[columName[i]].ToString());
                }
            }

            conn.Close();
            return resp;
        }
        public bool ExecuteProcedure(string procedureName , string[] listParams, string[] listValues)
        {
            // params , value != 
            if(listParams.Length != listValues.Length)
            {
                return false;
            }
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < listParams.Length; i++) {
                cmd.Parameters.Add(new SqlParameter(listParams[i],listValues[i]));
            }
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }
        public DataTable ExecuteProcedureTable(string procedureName, string[] listParams, string[] listValues)
        {
            // params , value != 
            if (listParams.Length != listValues.Length)
            {
                return null;
            }
            SqlCommand cmd = new SqlCommand(procedureName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < listParams.Length; i++)
            {
                cmd.Parameters.Add(new SqlParameter(listParams[i], listValues[i]));
            }
            conn.Open();
            DataTable dataTable;
            try
            {
                var rd = cmd.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(rd);
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            conn.Close();
            return dataTable;
        }
    }
}
