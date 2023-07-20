using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class AccountBLL
    {
        AccountAccess AccAccess= new AccountAccess();
        public string CheckLogin(Account Acc1)
        {
            if (Acc1.TaiKhoan == "")
                return "requeid_taikhoan";
            if (Acc1.MatKhau == "")
                return "requeid_matkhau";
            int code = AccAccess.Checklogin(Acc1);
            return code.ToString();
        }
    }
}
