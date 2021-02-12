using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QTS_SimpleBilling.Model
{
    public class ReceiptHeader
    {
        [Key]
        [MaxLength(200)]
        public int ReceiptNo { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        [MaxLength(60)]
        public string Employee { get; set; }

        [DefaultValue(0)]
        public float TotalDiscount { get; set; }

        public float SubTotal { get; set; }

        [DefaultValue(0)]
        public float NetTotal { get; set; }

        public float PaidAmount { get; set; }
        public float DueAmount { get; set; }

        [DefaultValue(0)]
        public int Status { get; set; }

        [DefaultValue(false)]
        public bool IsQuotation { get; set; }

        [DefaultValue(false)]
        public bool IsPaid { get; set; }

        [MaxLength(30)]
        public string CheckNo { get; set; }

    }
}