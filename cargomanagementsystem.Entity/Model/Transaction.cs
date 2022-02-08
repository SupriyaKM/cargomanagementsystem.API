using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace cargomanagementsystem.Entity.Model
{
   public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bill_no { get; set; }
        [Required]
        [ForeignKey("Sender_id")]
        public int customerid { get; set; }
        public virtual Cust_details Sender_id { get; set; }
        [Required]
        public string Type_of_Goods { get; set; }
        [Required]
        public int Goods_Qty { get; set; }
        [Required]
        public int Trans_amount { get; set; }
        [Required]
        public string Sending_date { get; set; }
        [Required]
        public string Receiving_date { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
        
    }
}
