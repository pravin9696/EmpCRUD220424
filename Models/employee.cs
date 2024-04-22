using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpCRUD220424.Models
{
    public class employee
    {
        [Display(Name="Employee ID")]
        public int empid { get; set; }
        
        public string name { get; set; }
        public string address { get; set; }
        public int contact { get; set; }
        public string   email { get; set; }

    }
}