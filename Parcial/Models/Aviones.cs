using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Aviones
    {
        [Key]
        public int IdAviones { get; set; }
        public int numero { get; set; }
        public string modelo { get; set; }
        public decimal peso { get; set; }
        public int capacidad { get; set; }
        

       
        
    }
}