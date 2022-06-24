using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FitnessService.Models
{
    [Table("Clients")]
    public class ClientModel
    {

        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина строки должна быть от 2 до 50 символов")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Required]
        [HiddenInput(DisplayValue = false)]
        public int Balance { get; set; }

        [Required]
        [HiddenInput(DisplayValue = false)]
        public int numberOfVisits { get; set; }

        [HiddenInput(DisplayValue = false)]
        public DateTime lastVisit { get; set; }

        [Required]
        [HiddenInput(DisplayValue = false)]
        [AllowNull]
        public CoachModel Coache { get; set; }

        [Required]
        [HiddenInput(DisplayValue = false)]
        public int Rate { get; set; }
    }
}
