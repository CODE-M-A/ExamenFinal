using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Hangares
    {
        [Key]
        public int IdHangar { get; set; }
        public int numero { get; set; }
        public int capacidad { get; set; }
        public string localizacion { get; set; }
        
       
        //public Universidad Universidad { get; set; }
    }
}
