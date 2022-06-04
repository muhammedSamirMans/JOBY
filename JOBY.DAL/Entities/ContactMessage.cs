﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace JOBY.DAL.Entities
{
    public class ContactMessage
    {
        [Key]
        public Int64 Id { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required][EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string  Subject { get; set; }
    }
}
