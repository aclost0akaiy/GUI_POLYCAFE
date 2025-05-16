using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCSAFE
{
    public class BUSNhanVien
    {
        DAL_NHANVIEN dalNhanVien = new DAL_NHANVIEN();
        public NhANVIEN Dangnhap(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            return dalNhanVien.GetNhANVIEN(username, password);
        }
    }
}
