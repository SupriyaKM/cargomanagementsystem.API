using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cargomanagementsystem.Entity.Model
{
    public class Cust_details
    {
        public string Sender_name { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sender_id { get; set; }
        public int Sender_mobno {get; set;}
        public string Sender_address { get; set; }
        public string Sender_City { get; set; }
        public int  Sender_pincode { get; set; }
        

        public string Receiver_name { get; set; }
        public int Receiver_id { get; set; }
        public int Receiver_mobno { get; set; }
        public string Receiver_address { get; set; }
        public string Receiver_city { get; set; }
        public int Receiver_pincode { get; set; }

    }
}
