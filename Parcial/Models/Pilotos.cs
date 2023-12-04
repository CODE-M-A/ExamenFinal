using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendMiguelVillca.Models
{
    public class Pilotos
    {
        [Key]
        public int IdNumeroLicencia { get; set; }
        public string Restricciones { get; set; }
        public int Salario { get; set; }
        public string Turno { get; set; }

    }
}
