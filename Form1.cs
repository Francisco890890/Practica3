namespace Practica_3
{
    public partial class Form1 : Form
    {
        float f_num, total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton de añadir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos el parametro
            f_num = float.Parse(textBox1.Text);
            total += f_num;
            textBox1.Text = " ";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = total.ToString();
        }
    }
}