using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class JenisKendaraan
    {
        public JenisKendaraan()
        {
            Kendaraan = new HashSet<Kendaraan>();
        }

        [Required(ErrorMessage = "Id Jenis Kendaraan tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Jenis Kendaraan tidak boleh kosong")]
        public string NamaJenisKendaraan { get; set; }

        public ICollection<Kendaraan> Kendaraan { get; set; }
    }
}
