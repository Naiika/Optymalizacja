namespace Optymalizacja2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Wroc�aw", CheckState.Unchecked);
            checkedListBox1.Items.Add("Opole", CheckState.Unchecked);
            checkedListBox1.Items.Add("Legnica", CheckState.Unchecked);
            checkedListBox1.Items.Add("Lubin", CheckState.Unchecked);
            checkedListBox1.Items.Add("G�og�w", CheckState.Unchecked);
            checkedListBox1.Items.Add("Wa�brzych", CheckState.Unchecked);
            checkedListBox1.Items.Add("Jelenia G�ra", CheckState.Unchecked);
            checkedListBox1.Items.Add("�widnica", CheckState.Unchecked);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}