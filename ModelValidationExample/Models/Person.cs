using System;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
	public class Person
	{
        [Required(ErrorMessage = " {0} es obligatorio")]
        [StringLength(40, MinimumLength = 3,
            ErrorMessage = "{0} debe tener minimo {2} y maximo {1} caracteres")]
        [RegularExpression("^[A-Za-z .]$",
            ErrorMessage = "{0} solo puede tener caracters alfabeticos, " +
            "espacios y numeros")]
        [Display(Name = "Nombre persona")]
        public string? PersonName { get; set; }

        [EmailAddress(ErrorMessage = "{0} debe ser valido")]
        public string? Email { get; set; }

        [EmailAddress(ErrorMessage = "{0} debe ser valido para el telefono")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "{0} no puede estar en blanco")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "{0} no puede estar en blanco")]
        [Compare("Password", ErrorMessage = "{0} no puede ser diferente a {1}")]
        [Display(Name ="Re enter password")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 99.99, ErrorMessage = "{0} es minimo {1} y maximo {2}")]
        public double? Price { get; set; }

        public override string ToString()
        {
            return $"Person object {PersonName} - {Email} {Phone} {Password} {ConfirmPassword} {Price}";
        }

    }
}

