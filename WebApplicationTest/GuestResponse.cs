using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationTest
{
    public class GuestResponse
    {
        // Атрибуты для проверки достоверности
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста укажите, придете ли вы")]
        public bool? WillAttend { get; set; }
    }
}   