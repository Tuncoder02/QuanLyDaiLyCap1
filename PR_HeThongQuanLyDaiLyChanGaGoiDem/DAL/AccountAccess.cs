using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccountAccess:DatabaseAccess
    {
        public int Checklogin(Account Acc1)
        {
            int code =CheckLoginDTO(Acc1);
            return code;
        }
    }
}
