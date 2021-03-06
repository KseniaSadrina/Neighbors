﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Neighbors.Models
{
    public class User: IdentityUser<int>
    {

        [Required(ErrorMessage = "Please provide first name")]
        [Display(Name = "First name")]
        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide last name")]
        [Display(Name = "Last name")]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide address")]
        public string Address { get; set; }

		[NotMapped]
		public string FullName => String.Join(" ", FirstName, LastName);

		// Cheack if there is relevant attribute
		[Required(ErrorMessage = "Please provide city")]
        public string City { get; set; }
        
        //Condiser of having the following properties under model view ???
        
        // Collection of all the products that people borrowed from me
       // public IList<Borrow> BorrowedProductFromMe { get; set; }

        public IList<Product> MyProducts { get; set; }
        
        // Collection of all the products that I borrowed from others
        public IList<Borrow> MyBorrowed { get; set; }

	}
}
