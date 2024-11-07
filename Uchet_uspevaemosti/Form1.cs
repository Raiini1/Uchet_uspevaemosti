using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet_uspevaemosti
{
    public partial class Attestachia : Form
    {
        private string ID_Attestachia;
        private string Uchenik_ID;
        private string Predmet_ID;
        private string Semestr;
        private string Ochenka;

        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public string PassID_Attestachia
        {
            get { return ID_Attestachia; }
            set { ID_Attestachia = value; }
        }
        public string PassUchenik_ID
        {
            get { return Uchenik_ID; }
            set { Uchenik_ID = value; }
        }
        public string PassPredmet_ID
        {
            get { return Predmet_ID; }
            set { Predmet_ID = value; }
        }
        public string PassSemestr
        {
            get { return Semestr; }
            set { Semestr = value; }
        }
        public string PassOchenka
        {
            get { return Ochenka; }
            set { Ochenka = value; }
        }

        public Attestachia()
        {
            InitializeComponent();
        }

        private void Attestachia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uсhet_uspevaemostiDataSet.Attestachia". При необходимости она может быть перемещена или удалена.
            this.attestachiaTableAdapter.Fill(this.uсhet_uspevaemostiDataSet.Attestachia);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void Form_Att_Activated(object sender, EventArgs e)
        {
            int n = dataGridViewAttest.Rows.Add();
            dataGridViewAttest.Rows[n].Cells[0].Value = ID_Attestachia;
            dataGridViewAttest.Rows[n].Cells[1].Value = Uchenik_ID;
            dataGridViewAttest.Rows[n].Cells[2].Value = Predmet_ID;
            dataGridViewAttest.Rows[n].Cells[3].Value = Semestr;
            dataGridViewAttest.Rows[n].Cells[4].Value = Ochenka;
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uсhet_uspevaemostiDataSet.Attestachia". При необходимости она может быть перемещена или удалена.
            this.attestachiaTableAdapter.Fill(this.uсhet_uspevaemostiDataSet.Attestachia);
            {
                connection = new SqlConnection("Data Source=DESKTOP-SUNPPQ;Initial Catalog=Uсhet_uspevaemosti;Integrated Security=True");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select Attestachia.ID_Attestachia, CONCAT(Uchenik.Familia, ' ', Uchenik.Imya, ' ', Uchenik.Otchestvo), Predmet.Nazvanie_predmeta, Attestachia.Semestr, Attestachia.Ochenka from Attestachia, Uchenik, Predmet where Attestachia.Uchenik_ID = Uchenik.ID_Uchenik and Attestachia.Predmet_ID = Predmet.ID_Predmet", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewAttest.DataSource = table;
                dataGridViewAttest.RowHeadersVisible = false;
                dataGridViewAttest.Columns[0].HeaderCell.Value = "№";
                dataGridViewAttest.Columns[0].Width = 30;
                dataGridViewAttest.Columns[1].HeaderCell.Value = "Ученик";
                dataGridViewAttest.Columns[1].Width = 180;
                dataGridViewAttest.Columns[2].HeaderCell.Value = "Предмет";
                dataGridViewAttest.Columns[2].Width = 90;
                dataGridViewAttest.Columns[3].HeaderCell.Value = "Семестр";
                dataGridViewAttest.Columns[3].Width = 60;
                dataGridViewAttest.Columns[4].HeaderCell.Value = "Оценка";
                dataGridViewAttest.Columns[4].Width = 50;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDelAtt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Attestacia WHERE ID_Attestacia = N'{textBoxDelAtt.Text}'", connection);
                MessageBox.Show("Удалено записей " + command.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewAttest.DataSource = table;
            }
        }

        private void dataGridViewAttest_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDelAtt.Text = dataGridViewAttest.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
