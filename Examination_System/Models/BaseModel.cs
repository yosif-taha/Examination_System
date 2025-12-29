using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examination_System.Models
{
    public class BaseModel<TKey>
    {
        [Required]
        public TKey Id { get; set; } 
        public int? CreatedBy { get; set; } 
        public int? UpdatedBy { get; set; } 
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsDeleted { get; set; } 
    }
}
