﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCS.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }
       
        public long UniqueMemberId { get; set; }

        [ValidateNever]
        public Department Department { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }


        public string ImageUrl { get; set; } = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSooCX-nPSHN0kCVdUnm-eptCPvUF04YaxeHQ&s";
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
