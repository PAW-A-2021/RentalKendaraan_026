using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Pengembalian
    {
        [Required(ErrorMessage = "Id Pengembalian tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tanggal Pengembalian tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public DateTime? TglPengembalian { get; set; }

        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Denda tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
