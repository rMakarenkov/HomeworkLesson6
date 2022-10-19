using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson6
{
	public class ClassHeirBinSearchRucursion : ClassFirst
	{
		private int positionInArray = -1;

		public int SearchElement(int[] array, int left, int right, string desired)
		{
			int mid = (left + right) / 2;

			if (array[mid] == Convert.ToInt32(desired))
			{
				positionInArray = mid;
				return positionInArray;
			}
			else
			{
				if (Convert.ToInt32(desired) < array[mid])
				{
					right = mid - 1;
				}
				else
				{
					left = mid + 1;
				}
			}

			return SearchElement(array, left, right, desired);
		}

		public override int PositionInArray
		{
			get { return positionInArray; }
		}
	}
}
