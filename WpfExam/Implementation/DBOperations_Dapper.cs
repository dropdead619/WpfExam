using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExam.Abstract;
using WpfExam.Models;

namespace WpfExam.Implementation
{
    public class DBOperations_Dapper : GetConnection, IDBOperations
    {
        public int AddTestResults(Test test)
        {
            using (var con = dbConnection)
            {
                string sql = @"pAddTestResults @id, @dateOfTest, @score, @timeTaken, @userId";
                return con.Execute(sql, new DynamicParameters(test));
            }
        }

        public int Create(User user)
        {
            using (var con = dbConnection)
            {
                string sql = @"pAddUser @id, @firstName, @lastName";
                return con.Execute(sql, new DynamicParameters(user));
            }
        }

        public IEnumerable<QuestionsAnswers> GetQuestions()
        {
            using (var con = dbConnection)
            {
                return con.Query<QuestionsAnswers>("select id, type, question from QuestionsAnswers");
            }
        }

        public IEnumerable<User> GetUserId(User user)
        {
            using (var con = dbConnection)
            {
                string sql = @"pFindUser @id";
                return con.Query<User>("select id from Users where id = @id");
            }
        }

        public IEnumerable<User> GetUserInfo()
        {
            using (var con = dbConnection)
            {
                return con.Query<User>("select s.*, p.name PositionName from Staff s join Positions p on s.positionId = p.id");
            }
        }

        public IEnumerable<User> SelectResultsByDate(DateTime begin_date, DateTime end_date)
        {
            throw new NotImplementedException();
        }
    }
}
