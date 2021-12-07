using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "Id Kendaraan tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        [Required(ErrorMessage = "Nomor Polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        [Required(ErrorMessage = "Nomor Stnk tidak boleh kosong")]
        public string NoStnk { get; set; }

        
        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan tidak boleh kosong")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
