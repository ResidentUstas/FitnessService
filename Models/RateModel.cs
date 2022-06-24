using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FitnessService.Models
{
    [Table("Rates")]
    public class RateModel
    {
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }

        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Display(Name = "Описание")]
        public string Text { get; set; }

        [Display(Name = "Стоимость")]
        public int Price { get; set; }
    }
}
