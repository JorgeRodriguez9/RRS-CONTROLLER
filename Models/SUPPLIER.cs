using System.ComponentModel.DataAnnotations;

namespace RRS_Controller.Models
{
    public class SUPPLIER
    {

        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        /////////////////
        public virtual ICollection<PRODUCT> PRODUCTS { get; set; }

    }
}
