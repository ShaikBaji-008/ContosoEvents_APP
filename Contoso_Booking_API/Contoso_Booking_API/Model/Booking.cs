using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso_Booking_API.Model
{
    [Table("Booking_Details")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Booking_Id { get; set; }
        public int Booking_Event_Id { get; set; }
        public decimal? Booking_Amount { get; set; }
        public int Booking_User_Id { get; set; }
        public int Booking_NumberofTickets { get; set; }
      //  public string Booking_Single_UnitPrice { get; set; }//
        public decimal? Booking_Single_UnitPrice { get; set; }
        //
    }
}
 