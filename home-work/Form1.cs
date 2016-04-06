using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace home_work
{
	public partial class Form1 : Form
	{
		string _testfilepath = "";
		string _trainfilepath = "";
		HopfieldData _database = new HopfieldData();
		int _testdataindex = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void testdata_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.ShowDialog();
			_testfilepath = file.FileName;
			testfilename.Text = _testfilepath;
		}

		private void traindata_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.ShowDialog();
			_trainfilepath = file.FileName;
			trainfilename.Text = _trainfilepath;
		}

		private void training_Click(object sender, EventArgs e)
		{
			_database.ReadData(_trainfilepath, _testfilepath);
			testpattern_comboBox.Items.Clear();

			string[] data = _database.GetTestData();
			for (int index = 0; index < data.Length;index++ )
			{
				if (data[index].Length > 0)
				{
					testpattern_comboBox.Items.Add(index + 1);
				}
			}
		}

		private void recall_button_Click(object sender, EventArgs e)
		{
			int[,] testdata = _database.GetTestMatrix(_testdataindex);
			double[,] w = _database.GetMatrixW();
			double[] theta = _database.GetTheta();

			HopfieldTrain h = new HopfieldTrain();
			double[,] output = h.Training(testdata, w, theta);
			int i = h.ErrorRate(_database.GetTrainMatrix(), output);
			recallpattern.Text = _database.GetTrainData()[i];
		}

		private void testpattern_comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] data = _database.GetTestData();
			string item = testpattern_comboBox.GetItemText(testpattern_comboBox.SelectedItem);
			_testdataindex = Int16.Parse(item) - 1;
			testpattern.Text = data[_testdataindex];
		}
	}
}
