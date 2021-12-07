using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        [Required(ErrorMessage = "Id Customer tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }

        [Required(ErrorMessage = "NIK tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage ="Hanya Boleh diisi oleh angka")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }

        [Required(ErrorMessage = "Nomor Hp tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        [MinLength(10, ErrorMessage ="No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 angka!")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
