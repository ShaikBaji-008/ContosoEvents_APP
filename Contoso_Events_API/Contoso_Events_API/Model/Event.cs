using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso_Events_API.Model
{
    [Table("Events_Details")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Event_ID { get; set; }

        public string Event_Name { get; set; }

        public string Event_Type { get; set; }

        public string Event_Location { get; set; }


        //

        [Required(ErrorMessage = "Start Date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? Event_Startdate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime? Event_EndDate { get; set; }
        //
        //public DateTime Event_Startdate { get; set; }

      //  public DateTime Event_EndDate { get; set; }

        public int Event_AvilableTickets { get; set; }

        public string Event_Status { get; set; }

        public string Event_Ticket_Catageory { get; set; }
    }
}


