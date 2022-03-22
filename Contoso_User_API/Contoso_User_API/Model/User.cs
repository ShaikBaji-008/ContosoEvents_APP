using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso_User_API.Model
{
    [Table("User_Details")]
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int User_Id { get; set; }


        public string User_UserName { get; set; }

        public string User_FirstName { get; set; }

        public string User_LastName { get; set; }

        public string User_Email { get; set; }

        public long User_Contact { get; set; }

        public string User_Password { get; set; }

        public string User_Gender { get; set; }

        public string User_Country { get; set; }
        public string User_Address { get; set; }



        //public string UserLoginId { get; set; }
       
        //public string UserPassword { get; set; }

    }


}



