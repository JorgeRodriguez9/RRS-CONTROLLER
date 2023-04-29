using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RRS_Controller.Models
{
    public class USER
    {

        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string? Name_User { get; set; }

        [StringLength(20)]
        public string? Password { get; set; }

        [ForeignKey("ROLE")]
        public string? Id_Role { get; set; }

        public virtual ROLE? ROLE { get; set; }

    }
}
