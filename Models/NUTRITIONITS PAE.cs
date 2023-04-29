using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRS_Controller.Models
{
    public class NUTRITIONITS_PAE
    {

        [Key]
        public int ID { get; set; }

        public int Document { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }
        [StringLength(20)]
        public string? Last_Name { get; set; }

        [StringLength(30)]
        public string? Adress { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [ForeignKey("USER")]
        public string? Id_User { get; set; }

        public virtual USER? USER { get; set; }

    }
}
