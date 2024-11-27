using System.Data;

namespace calc2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            textBox1.Text += currentButton.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
     
            try
            {
                var d = new DataTable();
                textBox1.Text = d.Compute(textBox1.Text, "").ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void ButtonClickDel(object sender, EventArgs e)
        {
            var str = "";
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                str += textBox1.Text[i];
            }

            textBox1 .Text = str;
        }


    }

}
