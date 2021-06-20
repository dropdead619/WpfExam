using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExam.Models;

namespace WpfExam.Abstract
{
    public interface IDBOperations
    {
        IEnumerable<User> GetUserInfo();
        IEnumerable<QuestionsAnswers> GetQuestions();
        IEnumerable<User> SelectResultsByDate(DateTime begin_date, DateTime end_date);
        int Create(User user);
        IEnumerable<User> GetUserId(User user);
        int AddTestResults(Test test);
    }
}