using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace home_work
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			int a = 11;
			int b = 13;
			double c = (double)(a / b);
			//string _trainningdataset = "1  \r\n 1 \r\n  1";
			//int[,] matrix = new int[3, 3];
			//int[,] matrix_t = new int[3, 3];

			//int rowindex=0, colindex=0;
			//bool newrow = true;

			//for (int i = 0; i < _trainningdataset.Length; i++)
			//{
			//    if (_trainningdataset[i] == ' ')
			//    {
			//        matrix[rowindex, colindex++] = 0;
			//        newrow = false;
			//    }
			//    else if (_trainningdataset[i] == '1')
			//    {
			//        matrix[rowindex, colindex++] = 1;
			//        newrow = false;
			//    }
			//    else
			//    {
			//        if (newrow == false)
			//        {
			//            rowindex++;
			//            colindex = 0;
			//            newrow = true;
			//        }
			//    }
			//}

			//int result = 0;
			//for (rowindex = 0; rowindex < matrix.GetLength(0); rowindex++)
			//{
			//    for (int line = 0; line < matrix.GetLength(0); line++)
			//    {
			//        for (colindex = 0; colindex < matrix.GetLength(0); colindex++)
			//        {
			//            result += matrix[rowindex, colindex] * matrix[line, colindex];
			//        }
			//        matrix_t[rowindex, line] = result;
			//        result = 0;
			//    }
			//}

			//int[,] sum = new int[3, 3];
			//for (int i = 0; i < matrix.GetLength(0); i++)
			//{
			//    for (int j = 0; j < matrix.GetLength(0); j++)
			//    {
			//        sum[i, j] = matrix_t[i, j] + (int)matrix[i, j];
			//    }
			//}


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
