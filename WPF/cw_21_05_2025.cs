namespace cw_21_05_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int IleCyfr(string n)
        {
            int suma = 0;
            for (int i = 0; i < n.Length; i++) suma++;
            return suma;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            if (IleCyfr(n) >= 6 && IleCyfr(n) <= 8)
            {
                int suma1 = 0;
                int suma2 = 0;
                foreach (char s in n)
                {
                    int x = Convert.ToInt32(s);
                    if (x % 2 == 0) suma1 += x;
                    else suma2 += x;
                }
                if (suma1 == suma2) label1.Text = "TAK";
                else label1.Text = "NIE";
            }
            else label1.Text = "Zła ilosc cyfr.";
        }
    }
}
