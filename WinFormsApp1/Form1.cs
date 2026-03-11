namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string food = Food.Text.Trim();

            if (food == "")
            {
                MessageBox.Show("請輸入餐點名稱！");
            }
            else if (food == "漢堡")
            {
                MessageBox.Show("漢堡賣完了，要不要試試薯條？");
            }
            else
            {
                MessageBox.Show("好的，正在為您準備 " + food + "...");
            }
        }
    }
}
