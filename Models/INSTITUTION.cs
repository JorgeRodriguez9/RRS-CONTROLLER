using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RRS_Controller.Models
{
    public class INSTITUTION
    {

        [Key]
        public int ID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int Document { get; set; }

        public int Phone_Number { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [ForeignKey("MANAGER_PAE")]
        public string Id_Manager { get; set; }

        public virtual MANAGER_PAE? MANAGER_PAE { get; set; }

    }
}
