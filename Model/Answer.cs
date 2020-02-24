using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Answer : BaseEntity
    {
        [Required]
        public string Sharing { get; set; }
        public Star Point { get; set; }     
        public int QuestionId { get; set; }   
        public virtual Question Question { get; set; }      
        public int UserId { get; set; }      
        public virtual User User { get; set; }
    }
}
