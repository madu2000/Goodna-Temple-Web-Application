﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnA.Models;

namespace AnA.ViewModel
{
    public class Ali_LoginViewModel : ALI_LOGINDTLS
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }


        public string ConfirmPassword { get; set; }
    }
}