using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : BaseEntity
    {
        public User()
        {
            Role = (Role)1;
            Questions = new HashSet<Question>();
            Answers = new HashSet<Answer>();
        }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Picture { get; set; }
        public Role Role { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
    public enum Role
    {
        Admin = 0,
        User = 1,
        Teacher = 2
    }
}

