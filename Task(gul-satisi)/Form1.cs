using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_gul_satisi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        double toplamGelir = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = Convert.ToInt32(maskedTextBox1.Text);
            double price = Convert.ToDouble(textBox2.Text);

            if (count <= 0 || price <= 0)
            {
                MessageBox.Show("Say və qiymət 0-dan böyük olmalıdır!", "Yanlış Dəyər", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = count * price;
            dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString(), result.ToString("F2"));
            toplamGelir += result;
            label4.Text = "Toplam gəlir: " + toplamGelir.ToString("F2");

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıxış edilsinmi?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
