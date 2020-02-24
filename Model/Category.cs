using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Questions = new HashSet<Question>();
        }
        [Required]
        public string CategoryName { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
