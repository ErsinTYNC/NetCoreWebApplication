using System.ComponentModel.DataAnnotations;

namespace Entites
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Display(Name ="Üst Kategorisi")]
        public int ParentId { get; set; }
        [Display(Name = "Katogori Adı"), Required, StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Katogori Açıklaması"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Katogori Resmi")]
        public string Image { get; set; }
    }
}
