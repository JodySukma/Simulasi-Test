using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Rumah_Idaman.Models
{
    public class LokasiRumahModel
    {

        [ForeignKey("Id")]
        [Display(Name = "Id") ]
        [Required(ErrorMessage = "{0} Harus Diisi.")]
        public int Id { get; set; }

        [Display(Name = "Tipe Rumah")]
        [Required(ErrorMessage = "{0} Harus Diisi.")]
        public string Type { get; set; }

        [Display(Name = "Longtitude")]
        public float Longtitude { get; set; }

        [Display(Name = "Latitude")]
        public float Latitude { get; set; }
    }
}
