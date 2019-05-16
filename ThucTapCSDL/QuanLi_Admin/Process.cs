using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User;

namespace QuanLi_Admin
{
    class Process
    {
        User.CallProcedure callProcedure = new User.CallProcedure();
        // func process đợt thi

        public List<List<string>> GetListDotThi()
        {
            List<List<string>> lstDotthi=callProcedure.GetDataProcedureSimple("GetAllDotThi",new string[] {"DotThiID","TenDotThi","Ngay" });
            return lstDotthi;
        }
        public DataTable GetListDotThiTable()
        {
            return  callProcedure.ExecuteProcedureTable("GetAllDotThi", new string[] { }, new string[] { });
        }
        public DataTable GetDanhSachThi(string dotThiID)
        {
            return callProcedure.ExecuteProcedureTable("GetDanhSachThiByDotThi", new string[] { "@dotThiID" }, new string[] {dotThiID });
        }
        public DataTable GetDanhSachDangKyByDotThiNull()
        {
            return callProcedure.ExecuteProcedureTable("GetThiSinhByDotThiNull", new string[] { }, new string[] { });
        }
        public DataTable GetDanhSachHoiDongThi(string dotThiID)
        {
            return callProcedure.ExecuteProcedureTable("GetCanBoByDotThiID", new string[] { "@maDotThi" }, new string[] { dotThiID });
        }
        public DataTable GetAllCanBo()
        {
            return callProcedure.ExecuteProcedureTable("GetAllCanBo", new string[] {  }, new string[] {  });
        }
        public DataTable GetChungChiByDotThi(string dotthiID)
        {
            return callProcedure.ExecuteProcedureTable("GetChungChiByDotThiID", new string[] { "@dotThiID" }, new string[] {dotthiID });
        }
        public DataTable GetKetQuaByDotThi(string dotthiID)
        {
            return callProcedure.ExecuteProcedureTable("GetKetQuaThiCapChungChiByDotThi", new string[] { "@dotThiID" }, new string[] { dotthiID });
        }
        public bool InsertDotThi(string tenDotThi, string ngayThi)
        {
            bool done = callProcedure.ExecuteProcedure("InsertDotThi", new string[] { "@tenDotThi", "@ngay" }, new string[] { tenDotThi, ngayThi });
            List<List<string>> dotThiIDMax = callProcedure.GetDataProcedureSimple("GetDotThiIDMax", new string[] { "DotThiIDMax" });
            if (done)
            {
                callProcedure.ExecuteProcedure("InsertDanhSachDangKy", new string[] { "@dotThiID", "@tenDanhSachDK" }, new string[] { dotThiIDMax[0][0], "Danh sách đăng kí của " + tenDotThi });
            }
            return done;
        }
        public bool UpdateDotThi(string dotThiID,string tenDotThi, string ngayThi)
        {
            return callProcedure.ExecuteProcedure("UpdateDotThi", new string[] { "@dotThiID", "@tenDotThi", "@ngay" }, new string[] {dotThiID, tenDotThi, ngayThi });
        }
        public DataTable GetDotThiByID(string dotThiID)
        {
            return callProcedure.ExecuteProcedureTable("GetDotThiByID", new string[] { "@dotThiID"}, new string[] { dotThiID});
        }
        public bool DeleteDotThiByID(string dotThiID)
        {
            return callProcedure.ExecuteProcedure("DeleteDotThi", new string[] { "@dotThiID" }, new string[] { dotThiID });
        }

        public bool InsertCanBo(string tenCanBo, string donVi, string capBac, string ghiChu)
        {
            return callProcedure.ExecuteProcedure("InsertCanBo", new string[] { "@hoTen", "@donVi", "@capBac", "@ghiChu" }, new string[] { tenCanBo,donVi,capBac,ghiChu });
        }

        public bool UpdateCanBo(string canBoID,string tenCanBo, string donVi, string capBac, string ghiChu)
        {
            return callProcedure.ExecuteProcedure("UpdateCanBo", new string[] { "@canBoID", "@hoTen", "@donVi", "@capBac", "@ghiChu" }, new string[] { canBoID,tenCanBo, donVi, capBac, ghiChu });
        }
        
        public bool DeleteCanBo(string canBoID)
        {
            return callProcedure.ExecuteProcedure("DeleteCanBo", new string[] { "@canBoID" }, new string[] { canBoID });
        }
        public bool ProcessInsertThiSinhToDSThi(string thiSinhID, string dotThiID, string SBD)
        {
            return callProcedure.ExecuteProcedure("InsertThiSinhToDSThi", new string[] { "@thiSinhID", "@dotThiID", "@SBD" }, new string[] { thiSinhID,dotThiID,SBD});

        }

        public List<List<string>> GetListNhiemVu()
        {
            return callProcedure.GetDataProcedureSimple("GetAllNhiemVu", new string[] { "NhiemVuID", "TenNhiemVu" });
        }
        public bool InsertCanBoToHoiDongThi(string dotThiID,string canBoID, string nhiemVuID)
        {
            return callProcedure.ExecuteProcedure("InsertCanBoToHoiDongThi", new string[] { "@dotThiID", "@canBoID", "@nhiemVuID" }, new string[] { dotThiID, canBoID, nhiemVuID });
        }

        public bool UpdateCanBoToHoiDongThi(string dotThiID, string canBoID, string nhiemVuID)
        {
            return callProcedure.ExecuteProcedure("UpdateCanBoInHoiDongThi", new string[] { "@dotThiID", "@canBoID", "@nhiemVuID" }, new string[] { dotThiID, canBoID, nhiemVuID });
        }

        public bool DeleteCanBoInHoiDongThi(string dotThiID, string canBoID)
        {
            return callProcedure.ExecuteProcedure("DeleteCanBoInHoiDongThi", new string[] { "@dotThiID", "@canBoID" }, new string[] { dotThiID, canBoID });
        }
        public bool DeleteSBDOfThiSinh(string SBD)
        {
            return callProcedure.ExecuteProcedure("DeleteThiSinhInDanhSachThi", new string[] { "@SBD"}, new string[] { SBD });
        }
        public bool DeleteThiSinh(string thiSinhID)
        {
            return callProcedure.ExecuteProcedure("DeleteThiSinh", new string[] { "@thiSinhID" }, new string[] { thiSinhID });
        }
        public bool UpdateSBD(string sbdold, string sbdnew)
        {
            return callProcedure.ExecuteProcedure("UpdateSBDForThiSinh", new string[] { "@SBDold", "@SBDnew" }, new string[] { sbdold,sbdnew });
        }
         public DataTable GetSBDnotyetKQ(string dotThiID)
        {
            return callProcedure.ExecuteProcedureTable("GetThiSinhNotYetKQ", new string[] { "@dotThiID" }, new string[] {dotThiID });
        }
        
        public DataTable GetOnlyKetQuaThiBySBD(string SBD)
        {
            return callProcedure.ExecuteProcedureTable("GetOnlyKetQuaThiBySBD", new string[] { "@SBD" }, new string[] { SBD });
        }
         public bool InsertKetQuaThi(string sbd, string diemtn,string word, string excel, string ppt)
        {
            return callProcedure.ExecuteProcedure("InsertKetQuaThi", new string[] { "@SBD", "@diemTracNghiem", "@word", "@excel", "@ppt" }, new string[] { sbd, diemtn, word,excel,ppt });
        }

        public bool UpdateKetQuaThi(string sbd, string diemtn, string word, string excel, string ppt)
        {
            return callProcedure.ExecuteProcedure("UpdateKetQuaThi", new string[] { "@SBD", "@diemTracNghiem", "@word", "@excel", "@ppt" }, new string[] { sbd, diemtn, word, excel, ppt });
        }
        public bool DeleteKetQuaThi(string sbd)
        {
            return callProcedure.ExecuteProcedure("DeleteKetQuaThi", new string[] { "@SBD" },new string[] { sbd});
        }
        public bool DeleteChungChi(string sbd)
        {
            return callProcedure.ExecuteProcedure("DeleteChungChi", new string[] { "@chungChiID" }, new string[] { sbd });
        }
        // các điểm > 5
        public DataTable GetSBDCanGetChungChi()
        {
            return callProcedure.ExecuteProcedureTable("GetSBDCanGetChungChi", new string[] { }, new string[] { });
        }
        public bool InsertChungChiBySBD(string sbd, string soVaoSo)
        {
            return callProcedure.ExecuteProcedure("InsertChungChiBySBD", new string[] { "@sbd", "@soVaoSo" }, new string[] { sbd, soVaoSo });
        }
        public bool UpdateChungChiBySBD(string sbd, string soVaoSo)
        {
            return callProcedure.ExecuteProcedure("UpdateChungChiBySBD", new string[] {  "@sbd", "@soVaoSo" }, new string[] { sbd, soVaoSo });
        }
        public DataTable GetSBDbyChungChiID(string chungChiID)
        {
            return callProcedure.ExecuteProcedureTable("GetSBDbyChungChiID", new string[] { "@chungChiID" }, new string[] {chungChiID });
        }
    }
}
