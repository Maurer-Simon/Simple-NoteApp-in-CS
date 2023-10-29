using System.Data;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMsg.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 200;
        }

        private void saveMsg_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMsg.Text);
            txtTitle.Clear();
            txtMsg.Clear();
        }

        private void readMsg_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMsg.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void deleteMsg_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}