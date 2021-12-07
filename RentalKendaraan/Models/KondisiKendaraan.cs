using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [Required(ErrorMessage = "Id Kondisi tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Nama Kondisi tidak boleh kosong")]
        public string NamaKondisi { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
