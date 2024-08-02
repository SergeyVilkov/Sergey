using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
		}

		double value;
		string symbol;
		string memory;

		public bool ConditionMethod()
		{
			if (memory == null || memory.Count() == 0 || memory.Contains(",")
				&& memory != null || memory != "" && memory.First() != '0')
				return true;
			else return false;
		}
		public void Equals(string symbol)
		{
			if (symbol == "/")
			{
				textBox1.Text = (value / double.Parse(memory)).ToString();
				memory = (value / double.Parse(memory)).ToString();
				this.symbol = null;
			}
			if (symbol == "*")
			{
				textBox1.Text = (value * double.Parse(memory)).ToString();
				memory = (value * double.Parse(memory)).ToString();
				this.symbol = null;
			}
			if (symbol == "+")
			{
				textBox1.Text = (value + double.Parse(memory)).ToString();
				memory = (value + double.Parse(memory)).ToString();
				this.symbol = null;
			}
			if (symbol == "-")
			{
				textBox1.Text = (value - double.Parse(memory)).ToString();
				memory = (value - double.Parse(memory)).ToString();
				this.symbol = null;
			}
		}

		#region dependency property ButtonNumberClick
		private void button0_Click(object sender, EventArgs e) //Button 0
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}

		private void button1_Click(object sender, EventArgs e) //Button 1
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
			
		}

		private void button2_Click(object sender, EventArgs e) //Button 2
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}

		private void button3_Click(object sender, EventArgs e) //Button 3
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}
		private void button4_Click(object sender, EventArgs e) //Button 4
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}

		private void button5_Click(object sender, EventArgs e) //Button 5
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}

		private void button6_Click(object sender, EventArgs e) //Button 6
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}
		private void button7_Click(object sender, EventArgs e) //Button 7
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}

		private void button8_Click(object sender, EventArgs e) //Button 8
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}

		private void button9_Click(object sender, EventArgs e) //Button 9
		{
			if (ConditionMethod() == true)
			{
				memory += (sender as Button).Text;
				textBox1.Text += (sender as Button).Text;
			}
		}
		#endregion

		private void buttonDot_Click(object sender, EventArgs e) //Button .
		{
			if (memory != null && memory != "" && !memory.Contains(","))
			{
				memory += ",";
				textBox1.Text += button1.Text;
			}
			else if (memory == null || memory == "")
			{
				memory += "0,";
				textBox1.Text += "0,";
			}
		}

		private void buttonEquals_Click(object sender, EventArgs e) //Button =
		{
			if (value != default && memory != null && memory != "")
			{
				Equals(symbol);
				value = double.Parse(memory);
				symbol = null;
			}
		}

		private void buttonDivide_Click(object sender, EventArgs e) //Button /
		{
			if (memory != null && memory != "" && memory.Last() != ',')
			{
				symbol = "/";
				textBox1.Text += symbol;
				value = double.Parse(memory);
				memory = null;
			}
			if (memory != null && value != default)
			{
				Equals(symbol);
				value = double.Parse(memory);
				memory = null;
				symbol = "/";
				textBox1.Text += symbol;
			}

		}

		private void buttonMultiply_Click(object sender, EventArgs e) //Button *
		{
			if (memory != null && memory != "" && memory.Last() != ',')
			{
				symbol = "*";
				textBox1.Text += symbol;
				value = double.Parse(memory);
				memory = null;
			}
			if (memory != null && value != default)
			{
				Equals(symbol);
				value = double.Parse(memory);
				memory = null;
				symbol = "*";
				textBox1.Text += symbol;
			}
		}

		private void buttonMinus_Click(object sender, EventArgs e) //Button -
		{
			if (memory != null && memory != "" && memory.Last() != ',')
			{
				symbol = "-";
				textBox1.Text += symbol;
				value = double.Parse(memory);
				memory = null;
			}
			if (memory != null && value != default)
			{
				Equals(symbol);
				value = double.Parse(memory);
				memory = null;
				symbol = "-";
				textBox1.Text += symbol;
			}
		}

		private void buttonPlus_Click(object sender, EventArgs e) //Button +
		{
			if (memory != null && memory != "" && memory.Last() != ',')
			{
				symbol = "+";
				textBox1.Text += symbol;
				value = double.Parse(memory);
				memory = null;
			}
			if (memory != null && value != default)
			{
				Equals(symbol);
				value = double.Parse(memory);
				memory = null;
				symbol = "+";
				textBox1.Text += symbol;
			}
		}

		private void buttonBack_Click(object sender, EventArgs e) //Button Back
		{
			if (textBox1.Text.Length > 0)
			{
				textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
				if(memory != null)
				memory = memory.Remove(memory.Length - 1);
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			memory = null;
		}

		private void buttonPow_Click(object sender, EventArgs e)
		{
			if (memory != null || memory != "")
			{
				textBox1.Text = (Math.Pow(double.Parse(memory), 2)).ToString();
				memory = (Math.Pow(double.Parse(memory), 2)).ToString();
			}
		}
	}
}
