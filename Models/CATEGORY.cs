using System.ComponentModel.DataAnnotations;

namespace RRS_Controller.Models
{
    public class CATEGORY
    {

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        ///////////////////////////
        
        public virtual ICollection<MENU> MENUS { get; set; }

    }
}
