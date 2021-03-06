﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodnaTemple.Web.ViewModel
{
    public class Ali_LoginViewModel
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