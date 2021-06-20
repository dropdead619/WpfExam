using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExam.Models.Abstract;

namespace WpfExam.Models
{
    [Table("TestResults")]
    public class Test : Entity
    {
        public int Score { get; set; }
        public TimeSpan TimeTaken { get; set; }
        public DateTime DateOfTest { get; set; }
        public Guid UserId { get; set; }
    }
}
