using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace JoseMiguelVaconezCLase3.Models
{
    public class Class
    {
        
        public string IdBanner { get; set; }
        public string? Nombre { get; set; }
        public Carrera Carrera { get; set; }

    }
}
