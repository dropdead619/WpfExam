using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfExam.Abstract;
using WpfExam.Implementation;
using WpfExam.Models;

namespace WpfExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IDBOperations service;
        DateTime startTestTime;

        public MainWindow()
        {
            InitializeComponent();
            service = new DBOperations_Dapper();
            startTestTime = DateTime.Now;
            dgQuestions.ItemsSource = service.GetQuestions();
        }

        private void btSubmit_Click(object sender, RoutedEventArgs e)
        {
            int score = 0;
            if(tb1.Text == "Canberra")
            {
                ++score;
            }
            if (tb2.Text == "8")
            {
                ++score;
            }
            if (tb3.Text == "Vladimir")
            {
                ++score;
            }
            if (tb4.Text == "Nigger-Man")
            {
                ++score;
            }
            if (tb5.Text == "7")
            {
                ++score;
            }
            score = (int)(score / (double)5 * 100);

            Test testResults = new Test() {
                DateOfTest = DateTime.Now,
                Score = score,
                TimeTaken = DateTime.Now.Subtract(startTestTime),
                UserId = FUser.user.Id
            };
            service.AddTestResults(testResults);
            MessageBox.Show($"Results:\n" +
                 $"Questions - 5\n" +
                $"Score - {testResults.Score}%\n" +
                $"Time taken - {testResults.TimeTaken.Minutes} minutes {testResults.TimeTaken.Seconds} seconds\n" +
                $"Date: {testResults.DateOfTest.Date}");
        }
    }
}
