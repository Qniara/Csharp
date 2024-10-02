namespace cw_02_10_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Babelek(int[] T)
        {
            int temp;
            for (int i = 0; i < T.Length - 1; i++)
            {
                for (int j = 1; j < T.Length; j++)
                {
                    if (T[i] > T[j])
                    {
                        temp = T[i];
                        T[i] = T[j];
                        T[j] = temp;
                    }
                }
            }
            return T;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = int.Parse(textBox1.Text);
            int[] T = new int[n];
            for (int i = 0; i < n; i++)
            {
                T[i] = r.Next(1, 100);
                MessageBox.Show("" + T[i]);
            }
            int[] T2 = Babelek(T);
            MessageBox.Show("Posortowane: ");
            foreach (int i in T2)
            {
                MessageBox.Show("" + i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
