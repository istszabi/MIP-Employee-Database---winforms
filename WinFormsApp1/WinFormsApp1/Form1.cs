using MIP1;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Person> people;
        public Form1()
        {
            InitializeComponent();
            

            button1.Text = "Display names";

            button2.Text = "Clear";

            people = new List<Person>();
            var e1 = new Employee(
            "James",
            "Cole",
            37,
            "jamescole@gmail.com",
            "TechCorp",
            "Employee",
            7,
            2500
            );
            var m1 = new Manager(
                "Jack",
                "Randy",
                45,
                "jackrandy@gmail.com",
                "TechCorp",
                "Manager",
                15,
                3400,
                800
                );
            var m2 = new Manager(
               "Michael",
               "Kors",
               38,
               "michaelkros@gmail.com",
               "TechCorp",
               "Manager",
               12,
               3100,
               500
               );
            Director d1 = Director.GetInstance(
                "Alex",
                "Fang",
                45,
                "alexfang@gmail.com",
                "TechCorp",
                "Director",
                22,
                4500,
                1200
                );

            people.Add(e1);
            people.Add(m1);
            people.Add(m2);
            people.Add(d1);


            button1.Click += button1_Click;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                richTextBox1.Clear();

              
                StringWriter sw = new StringWriter();
                TextWriter originalConsole = Console.Out;
                Console.SetOut(sw);

            
                foreach (Person p in people)
                {
                    Console.WriteLine(p.ToString());
                    p.Introduction(); 
                    Console.WriteLine();
                }

              
                Console.SetOut(originalConsole);

      
                richTextBox1.Text = sw.ToString();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();


            richTextBox1.AppendText("Loading...");



            string joke = await Task.Run(async () =>
            {

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
                    using JsonDocument doc = JsonDocument.Parse(response);
                    JsonElement root = doc.RootElement;


                    return root.GetProperty("value").GetString();
                }
            });
            richTextBox1.Clear();
            richTextBox1.AppendText(joke + Environment.NewLine);
        }
    }
}
