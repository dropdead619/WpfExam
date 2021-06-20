using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExam.Models.Abstract;

namespace WpfExam.Models
{
    [Table("QuestionsAnswers")]
    public class QuestionsAnswers : Entity
    {
        public string Question { get; set; }
        public string Type { get; set; }
        public string Answer { get; set; }
    }
}
