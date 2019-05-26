using Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Admin
{
    public class AdminService : IAdminService
    {
        public string TestMethod()
        {
            return "working";
        }
    }
}
