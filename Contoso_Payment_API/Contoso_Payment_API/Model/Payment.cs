using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso_Payment_API.Model
{
    [Table("Payment_Details")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Payment_Id { get; set; }

        public int Payment_User_Id { get; set; }

        public int Payment_Event_Id { get; set; }

        public decimal?  Payment_Amount { get; set; }


    }
}



