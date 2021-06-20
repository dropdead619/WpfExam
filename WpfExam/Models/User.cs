using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExam.Abstract;
using WpfExam.Models.Abstract;

namespace WpfExam.Models
{
    [Table("Users")]
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }      
    }
}
