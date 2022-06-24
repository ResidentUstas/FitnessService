using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FitnessService.Models
{
    [Table("Couches")]
    public class CoachModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; } // ID 
        [Display(Name = "ФИО тренера")]
        public string Fio { get; set; }
        [Required]
        [StringLength(2000, MinimumLength = 10, ErrorMessage = "Описание должно быть от 10 до 2000 символов")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Информация о тренере")]
        public string Information { get; set; }
        [Required]
        [StringLength(2000, MinimumLength = 10, ErrorMessage = "Длина отзыва должна быть от 10 до 2000 символов")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Текст отзыва")]
        public string Text { get; set; }
    }
}
