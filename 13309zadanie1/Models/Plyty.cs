using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13309zadanie1.Models
{
    public class Plyty
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę podać szerokość płyty")]
        [Range(0, 2100, ErrorMessage = "Szerokość płyty od 0 do 2100")]
        public int Szerokosc { get; set; }
        [Required(ErrorMessage = "Proszę podać wysokość płyty")]
        [Range(0, 2850, ErrorMessage = "Wysokość płyty od 0 do 2850")]
        public int Wysokosc { get; set; }
        [RegularExpression(@"\d+(?:,\d{1,2})?", ErrorMessage = "Prosze podac liczbe z max 2 miejscami po przecinku")]
        [Required(ErrorMessage = "Proszę podać cenę za 1m^2")]
        [Range(0, 99999.99, ErrorMessage = "Cena od 0 do 99999,99")]
        public decimal Cena { get; set; }
        [Required(ErrorMessage = "Proszę podać ilość płyt")]
        [Range(0, 200, ErrorMessage = "Ilość płyt od 0 do 200")]
        public int Ilosc { get; set; }
    }
}
