using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfApp
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }


        public override string ToString()
        {
            return $"Ad:{this.Ad}-Soyad:{this.Soyad}-Numara:{this.Numara}";
        }
    }
}
