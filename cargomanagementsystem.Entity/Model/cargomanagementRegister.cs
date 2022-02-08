using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace cargomanagementsystem.Entity.Model
{
   public class cargomanagementRegister
    {
        public string Name { get; set; }
        [Key]
        public string Emailid { get; set; }

        public int Mobile { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}
