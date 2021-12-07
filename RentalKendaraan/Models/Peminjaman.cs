using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        [Required(ErrorMessage = "Id Peminjaman tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tanggal Peminjaman tidak boleh kosong")]
        public DateTime? TglPeminjaman { get; set; }

        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int? Biaya { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
