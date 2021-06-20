using NLog;
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
using System.Windows.Shapes;
using WpfExam.Implementation;
using WpfExam.Models;

namespace WpfExam
{
    /// <summary>
    /// Interaction logic for FUser.xaml
    /// </summary>
    public partial class FUser : Window
    {
        DBOperations_Dapper service;
        public static User user;
        static Logger logger = LogManager.GetCurrentClassLogger();
        public FUser()
        {
            InitializeComponent();
            service = new DBOperations_Dapper();
            logger.Info("App is currently running");
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            user = new User()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text
            };
            try
            {
                service.Create(user);
            }
            catch
            {
                MessageBox.Show("Error!");
                this.Close();

            } finally
            {
                logger.Info($"Added user {user.FirstName} {user.LastName}");
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
            }
        }
    }
}
