using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }
        [Required(ErrorMessage = "Id Gender tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh diisi oleh angka")]
        public int IdGender { get; set; }


        [Required(ErrorMessage = "Nama Gender tidak boleh kosong")]
        
        [MaxLength(1, ErrorMessage = "Nama Gender maksimal 1 huruf!")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
