using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "Id jaminan tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Nama jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }

        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
