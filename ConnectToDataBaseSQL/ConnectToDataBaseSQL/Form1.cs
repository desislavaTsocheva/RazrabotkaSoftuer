using MySqlConnector;

namespace ConnectToDataBaseSQL
{
    public partial class Form1 : Form
    {
        string connect = "server= 192.168.1.235;" + "port=3306;" + "user=REMOTE;" + 
        "password=Aa123456@" + "database=minions";

        MySqlConnection connection;
        MySqlCommand query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connect);
            if (connection.State==0)
            {
                connection.Open();
            }
            MessageBox.Show("Connection open!");
            string sql = "Select minions.id,minions.Name,minions.Age" + "From minions";
            query = new MySqlCommand(sql, connection);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read()) 
            {
                listBox1.Items.Add($"{reader[0]} --> {reader[1]} is {reader[2]} years old");
            }
            reader.Close();
            connection.Close();



        }
    }
}