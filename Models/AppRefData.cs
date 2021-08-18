using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AppRefData
    {
        public int KeyID { get; set; }
        public string KeyName { get; set; }
        public string Customer_Name { get; set; }

        public string Project_Name { get; set; }

        public string Project_Id { get; set; }
        public List<AppRefData> ProjectInfo { get; set; }
    }
}