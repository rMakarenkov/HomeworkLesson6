using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson6
{
	public class ClassHeirBinSearch : ClassFirst
	{
		private int positionInArray = -1;

		public override void SearchElementEnum(int[] array, string desired)
		{
			int left = 0;
			int righh = array.Length - 1;
			int searchElement = Convert.ToInt32(desired);

			while (left <= righh)
			{
				int mid = (left + righh) / 2;

				if (searchElement == array[mid])
				{
					positionInArray = mid;
					break;
				}

				if (searchElement < array[mid])
				{
					righh = mid - 1;
				}

				else

				{
					left = mid + 1;
				}
			}
		}

		public override int PositionInArray
		{
			get { return positionInArray; }
		}
	}
}

