using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing.Drawing2D;

namespace home_work
{
	class HopfieldData
	{
		private const int _dimension = 13;
		private string[] _trainningdataset;
		private string[] _testdataset;
		private double[,] _matrix_w = new double[_dimension, _dimension];
		private double[] _theta = new double[_dimension];
		private List<int[,]> _testdatalist = new List<int[,]>();
		private List<int[,]> _traindatalist = new List<int[,]>();


		public double[,] GetMatrixW() { return _matrix_w; }
		public double[] GetTheta() { return _theta; }
		public string[] GetTestData() { return _testdataset; }
		public int[,] GetTestMatrix(int i) { return _testdatalist[i]; }

		public string[] GetTrainData() { return _trainningdataset; }
		public List<int[,]> GetTrainMatrix() { return _traindatalist; }

		public void ReadData(string train_filepath,string test_filepath)
		{
			if (train_filepath.IndexOf("HOPFIELD") != -1)
			{
				string[] split = { "\r\n\r\n" };
				string text = File.ReadAllText(train_filepath);
				_trainningdataset = text.Split(split, StringSplitOptions.None);
				text = File.ReadAllText(test_filepath);
				_testdataset = text.Split(split, StringSplitOptions.None);
			}
			else
			{
				string[] split = { "\r\n\r\n\r\n", "\r\n   \r\n   \r\n"};
				string text = File.ReadAllText(train_filepath);
				_trainningdataset = text.Split(split, StringSplitOptions.None);
				text = File.ReadAllText(test_filepath);
				_testdataset = text.Split(split, StringSplitOptions.None);

				int[,] matrix_sum = GetData_Transpose_Sum(_trainningdataset);
				GetWeight_Matrix(matrix_sum);
				GetThetaData();
				GetTestDataMatrix(_testdataset);
			}
		}
		private void GetTestDataMatrix(string[] data)
		{
			_testdatalist.Clear();
			for (int index = 0; index < data.Length; index++)
			{
				_testdatalist.Add(GetMatrix(data[index]));
			}
		}
		private void GetThetaData()
		{
			for (int rowindex = 0; rowindex < _matrix_w.GetLength(0);rowindex++ )
			{
				for (int colindex = 0; colindex < _matrix_w.GetLength(0); colindex++)
				{
					_theta[rowindex] += _matrix_w[rowindex,colindex];
				}
			}
		}
		private void GetWeight_Matrix(int[,] data)
		{
			double[,] matrix = new double[_dimension, _dimension];
			double[,] matrix_i = new double[_dimension, _dimension];

			for (int i = 0; i < data.GetLength(0); i++)
			{
				matrix_i[i, i] = 1;
				for (int j = 0; j < data.GetLength(0); j++)
				{
					double a = (double)data[i, j] / _dimension;
					double b = (double)matrix_i[i, j] * _trainningdataset.Length / _dimension;
					_matrix_w[i, j] = (double)a - b;
				}
			}
		}
		private int[,] GetData_Transpose_Sum(string[] data)
		{
			_traindatalist.Clear();
			List<int[,]> list = new List<int[,]>();
			int[,] matrix_sum = new int[_dimension, _dimension];
			for (int index = 0; index < data.Length; index++)
			{
				_traindatalist.Add(GetMatrix(data[index]));
				list.Add(GetMatrix_Transpose(_traindatalist[index]));
			}

			foreach (var item in list)
			{
				for (int i = 0; i < item.GetLength(0); i++)
				{
					for (int j = 0; j < item.GetLength(0); j++)
					{
						matrix_sum[i, j] = matrix_sum[i, j] + item[i, j];
					}
				}
			}

			return matrix_sum;
		}
		private int[,] GetMatrix_Transpose(int[,] data)
		{
			int[,] matrix_t = new int[_dimension, _dimension];
			int rowindex = 0, colindex = 0;
			int result = 0;
			for (rowindex = 0; rowindex < data.GetLength(0); rowindex++)
			{
				for (int line = 0; line < data.GetLength(0); line++)
				{
					for (colindex = 0; colindex < data.GetLength(0); colindex++)
					{
						result += data[rowindex, colindex] * data[line, colindex];
					}
					matrix_t[rowindex, line] = result;
					result = 0;
				}
			}
			return matrix_t;
		}
		private int[,] GetMatrix(string data)
		{
			int[,] matrix = new int[_dimension, _dimension];

			int rowindex = 0, colindex = 0;
			bool newrow = true;

			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == ' ')
				{
					matrix[rowindex, colindex++] = -1;
					newrow = false;
				}
				else if (data[i] == '1')
				{
					matrix[rowindex, colindex++] = 1;
					newrow = false;
				}
				else
				{
					if (newrow == false)
					{
						rowindex++;
						colindex = 0;
						newrow = true;
					}
				}
			}

			return matrix;
		}
	}
}
