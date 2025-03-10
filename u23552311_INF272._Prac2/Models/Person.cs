using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23552311_INF272._Prac2.Models
{
	public class Person
	{

        [Display(Name = "Student number")]

        public string StudentNumber { get; set; }

        [Display(Name = "Fist Name")]

        public string FirstName { get; set; }


        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Display(Name = "Email Address")]

        public string Email { get; set; }

        [Display(Name = "Link to personal page")]

        public string myLink { get; set; }
    }
}