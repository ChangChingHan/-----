using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace home_work
{
	class HopfieldTrain
	{
		private const int _dimension = 13;
		public double[,] Training(int[,] testdata, double[,] w, double[] theta)
		{
			double n = 0;
			double[,] output = new double[_dimension,_dimension];
			for (int testcol = 0; testcol<w.GetLength(0);testcol++ )
			{
				for (int row = 0; row < w.GetLength(0); row++)
				{
					n = 0;
					for (int col = 0; col < w.GetLength(0); col++)
					{
						n = n + (w[row, col] * testdata[col, testcol]);
					}

					if (n == 0)
					{
						output[row, testcol] = 0;
					}
					else if ((n - theta[row]) > theta[row])
					{
						output[row,testcol] = 1;
					}
					else if((n - theta[row]) < theta[row])
					{
						output[row,testcol] = -1;
					}
				}
			}
			return output;
		}

		public int ErrorRate(List<int[,]> traindata, double[,] output)
		{
			int newerror = 0, olderror = 0;
			int index = 0;
			int minindex = 0;
			foreach (var item in traindata)
			{
				newerror = 0;
				for (int row = 0; row < output.GetLength(0); row++)
				{
					for (int col = 0; col < output.GetLength(0); col++)
					{
						if (item[row, col] != output[row, col])
						{
							newerror++;
						}
					}
				}

				if (olderror == 0)
				{
					olderror = newerror;
				}
				else
				{
					if (newerror < olderror)
					{
						minindex = newerror;
					}
				}
				index++;
			}

			return minindex;
		}
	}
}
