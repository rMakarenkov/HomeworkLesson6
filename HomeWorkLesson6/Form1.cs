using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkLesson6
{

	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		ClassFirst parent = new ClassFirst();
		int[] mas;
		ClassHeirBinSearch son = new ClassHeirBinSearch();
		ClassHeirBinSearchRucursion son2 = new ClassHeirBinSearchRucursion();

		private void button1_Click(object sender, EventArgs e)
		{
			textBoxViewResult.Clear();
			mas = parent.CreateArray(Convert.ToInt32(textBoxDimensionArray.Text));

			foreach (var item in mas)
			{
				textBoxViewResult.Text += item + " ";
			}
		}

		private void buttonSortArray_Click(object sender, EventArgs e)
		{
			textBoxViewResult.Clear();
			parent.SortArray(mas);

			foreach (var item in mas)
			{
				textBoxViewResult.Text += item + " ";
			}
		}

		private void buttonSearchDesiredEkement_Click(object sender, EventArgs e)
		{
			if (textBoxAddSearchElement.Text == "")
			{
				MessageBox.Show("Ошибка, пустое поля для ввода искомого элемента");
			}
			else
			{
				parent.SearchElementEnum(mas, textBoxAddSearchElement.Text);
				int result = parent.PositionInArray;

				if (result >= 0)
				{
					MessageBox.Show($"Искомый элемент находится на позиции {result} в массиве");
				}
				else
				{
					MessageBox.Show("Искомого элемента нет в массиве");
				}
			}
		}

		private void buttonBinSearch_Click(object sender, EventArgs e)
		{
			if (textBoxAddSearchElement.Text == "")
			{
				MessageBox.Show("Ошибка, пустое поля для ввода искомого элемента");
			}
			else
			{
				son.SearchElementEnum(mas, textBoxAddSearchElement.Text);
				int result = son.PositionInArray;

				if (result >= 0)
				{
					MessageBox.Show($"Искомый элемент находится на позиции {result} в массиве");
				}
				else
				{
					MessageBox.Show("Искомого элемента нет в массиве");
				}
			}
		}

		private void buttonBinSearchRucursion_Click(object sender, EventArgs e)
		{
			if (textBoxAddSearchElement.Text == "")
			{
				MessageBox.Show("Ошибка, пустое поля для ввода искомого элемента");
			}
			else
			{
				son2.SearchElement(mas, 0, mas.Length, textBoxAddSearchElement.Text);
				int result = son2.PositionInArray;

				if (result >= 0)
				{
					MessageBox.Show($"Искомый элемент находится на позиции {result} в массиве");
				}
				else
				{
					MessageBox.Show("Искомого элемента нет в массиве");
				}
			}
		}
	}
}
