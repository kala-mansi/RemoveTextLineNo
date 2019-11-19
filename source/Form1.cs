using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RemoveLineNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String content = richTextBox1.Text;
            Console.WriteLine(content);
            if (content.Length > 0)
            {
                List<String> lst = new List<string>();
                String[] arr = content.Split(new String[] {"\n"}, StringSplitOptions.None);
                foreach (var line in arr)
                {
                    Regex regNum = new Regex("^[0-9]");
                    if (regNum.IsMatch(line))
                    {
                        //("是数字开头的");
                        var pos = line.IndexOf(" ");
                        if (pos > 0)
                        {
                            lst.Add(line.Substring(pos));
                        }
                        else if (line.IndexOf("\t") > 0)
                        {
                            pos = line.IndexOf("\t");
                            if (pos > 0)
                            {
                                lst.Add(line.Substring(pos));
                            }
                        }
                        else
                        {
                            lst.Add(line);
                        }
                        
                    }
                    else
                    {
                        lst.Add(line);
                    }
                }

                var output  = String.Join( "\n",lst );
                richTextBox1.Text = output;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String content = richTextBox1.Text;
            Console.WriteLine(content);
            if (content.Length > 0)
            {
                List<String> lst = new List<string>();
                String[] arr = content.Split(new String[] {"\n"}, StringSplitOptions.None);
                foreach (var line in arr)
                {
                    Regex regNum = new Regex(@"^[\s]*$");
                    if (regNum.IsMatch(line))
                    {
                        //是一个空行
                    }
                    else
                    {
                        lst.Add(line);
                    }
                }

                var output  = String.Join( "\n",lst );
                richTextBox1.Text = output;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String content = richTextBox1.Text;
            Console.WriteLine(content);
            if (content.Length > 0)
            {
                List<String> lst = new List<string>();
                String[] arr = content.Split(new String[] {"\n"}, StringSplitOptions.None);
                foreach (var line in arr)
                {
                        lst.Add(line.TrimEnd());
                }
                var output  = String.Join( "\n",lst );
                richTextBox1.Text = output;
            }
        }
    }
}