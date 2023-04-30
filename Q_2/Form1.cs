using System;
using System.Diagnostics;
using System.Security.Policy;
using static System.Net.WebRequestMethods;

namespace Q_2
{
    public partial class DDoSAttack : Form
    {
        List<Process> processList;
        public DDoSAttack()
        {
            processList = new List<Process>(); 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // start
        {
            try
            {
                int inputAmount = int.Parse(amount.Text);
                string inputPath = path.Text;
                for (int i = 0; i < inputAmount; i++)
                {
                    Process process = Process.Start("cmd", "/c start " + inputPath);
                    processList.Add(process);
                }
            }
            
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process process in processList)
                {
                    process.Kill();
                }
                processList.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void path_TextChanged(object sender, EventArgs e)
        {

        }
    }
}