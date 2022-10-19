using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson6
{
	public class ClassFirst
	{
		private int positionInArray = -1;

		public int[] CreateArray(int arrayLenth)
		{
			int[] array = new int[arrayLenth];
			Random randomValue = new Random();

			for (int i = 0; i < arrayLenth; i++)
			{
				array[i] = randomValue.Next(-50, 100);
			}

			return array;
		}

		public void SortArray(int[] array)
		{
			for (int j = 0; j < array.Length; j++)
			{
				for (int i = 0; i < array.Length - 1; i++)
				{
					if (array[i] > array[i + 1])
					{
						int temp = array[i];
						array[i] = array[i + 1];
						array[i + 1] = temp;
					}
				}
			}
		}

		public virtual void SearchElementEnum(int[] array, string desired)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == Convert.ToInt32(desired))
				{
					positionInArray = i;
					break;
				}
			}
		}

		public virtual int PositionInArray
		{
			get { return positionInArray; }
		}
	}
}

