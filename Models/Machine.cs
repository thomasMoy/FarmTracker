using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace FarmEquipmentTracker.Models
{
    public class Machine
    {
        [Key]
        public int id { get; set; }
        public string registration { get; set; }
        public string makeModel { get; set; }  
        public string machineType { get; set; }
        public string keyTagCode { get;set; }
        public bool inYard { get; set; }

    }
}
