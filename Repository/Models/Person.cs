using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Name field Can't be empty.")]
        [StringLength(25,MinimumLength =3,ErrorMessage ="Not a Valid Name")]
        public string name { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^+?\(?([0-9]{2})?[-. ]?([0-9]{4})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid Phone number")]
        public string phoneNumber { get; set; }
        public string address { get; set; }
    }
}
