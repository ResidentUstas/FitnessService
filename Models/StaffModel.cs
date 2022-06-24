using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FitnessService.Models
{
    public class StaffModel
    {
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }

        [StringLength(300, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 20 до 300 символов")]
        [Display(Name = "ФИО")]
        public string Fio { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Display(Name = "Должность")]
        public string Position { get; set; }
    }
}
