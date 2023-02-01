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
using System.Data.SqlClient;


//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    await connection.OpenAsync();
//    SqlCommand command = new SqlCommand();
//    command.CommandText = "CREATE TABLE Users(Id INT PRIMARY KEY IDENTITY,Name NVARCHAR(100) NOT NULL,Emall NVARCHAR(100) NOT NULL,UserName NVARCHAR(100) NOT NULL,Passwo NVARCHAR(100) NOT NULL)";
//    command.Connection = connection;
//    await command.ExecuteNonQueryAsync();
//}
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    await connection.OpenAsync();
//    SqlCommand command = new SqlCommand(sqlExpression, connection);
//    await command.ExecuteNonQueryAsync();
//}
//Console.Read();
namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source = HOME-PC; Initial Catalog = adonetdb; Trusted_Connection=True";  
        public MainWindow()
        {
            InitializeComponent();

        }
        private void TextBox1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBox1.Text = string.Empty;
        }
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox1_Copy_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBox1_Copy.Text = string.Empty;
        }
        private void TextBox1_Copy1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBox1_Copy1.Text = string.Empty;
        }
        private void TextBox1_Copy2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBox1_Copy2.Text = string.Empty;
        }
        private async void Button1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string Name1;
            string Email;
            string UserN;
            string Pass;
            Name1 =TextBox1.Text ;
            Email = TextBox1_Copy.Text;
            UserN=TextBox1_Copy1.Text;
            Pass=TextBox1_Copy2.Text;
            string sqlExpression = $"INSERT INTO Users (Name , Emall,UserName, Passwo) VALUES({Name1},{Email},{UserN},{Pass})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}
