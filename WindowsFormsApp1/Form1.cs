using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Add_Click(object sender, EventArgs e)
		{
			int nilai1 = int.Parse(textBox1.Text);
			int nilai2 = int.Parse(textBox2.Text);
			int hasil;

			hasil = nilai1 + nilai2;
			textBox3.Text = hasil.ToString();
		}

		private void Subtract_Click(object sender, EventArgs e)
		{
			int nilai1 = int.Parse(textBox1.Text);
			int nilai2 = int.Parse(textBox2.Text);
			int hasil;

			hasil = nilai1 - nilai2;
			textBox3.Text = hasil.ToString();
		}

		private void Multiply_Click(object sender, EventArgs e)
		{
			int nilai1 = int.Parse(textBox1.Text);
			int nilai2 = int.Parse(textBox2.Text);
			int hasil;

			hasil = nilai1 * nilai2;
			textBox3.Text = hasil.ToString();
		}

		private void Divide_Click(object sender, EventArgs e)
		{
			float nilai1 = float.Parse(textBox1.Text);
			float nilai2 = float.Parse(textBox2.Text);
			float hasil;

			hasil = nilai1 / nilai2;
			textBox3.Text = hasil.ToString("0.000");
		}

		private void Modulo_Click(object sender, EventArgs e)
		{
			int nilai1 = int.Parse(textBox1.Text);
			int nilai2 = int.Parse(textBox2.Text);
			int hasil;

			hasil = nilai1%nilai2;
			textBox3.Text = hasil.ToString();
		}

		private void Power_Click(object sender, EventArgs e)
		{
			int nilai1 = int.Parse(textBox1.Text);
			int nilai2 = int.Parse(textBox2.Text);
			double hasil;

			hasil = Math.Pow(nilai1, nilai2);
			textBox3.Text = hasil.ToString();
		}
	}
}
