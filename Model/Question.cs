using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Question : BaseEntity
    {

        public Question()
        {
            Answers = new HashSet<Answer>();
        }
        [Required]
        public string Sharing { get; set; }
        [Required]
        public string Explanation { get; set; }
        public Star Point { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }   
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

    }

    public enum Star
    {
        Weak = 1,
        Valid = 2,
        Middle = 3,
        Normal = 4,
        Good = 5
    }
}

