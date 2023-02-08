using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author Stewart, Date 03/02/2023
// Simple data table example
namespace DataTable
{
    public partial class FormDataTable : Form
    {
        public FormDataTable()
        {
            InitializeComponent();
        }
        // global variables - 2 Dim array of string
        static int row = 12;
        static int col = 5;
        string[,] DataTable = new string[row, col];

        private void FillArray()
        {
            Random random = new Random();
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    DataTable[x, y] = random.Next(10, 99).ToString();
                }
            }
        }
        private void DisplayArray()
        {
            ListViewData.Items.Clear();
            for (int x = 0; x < row; x++)
            {
                ListViewItem item = new ListViewItem(DataTable[x, 0]);
                item.SubItems.Add(DataTable[x, 1]);
                item.SubItems.Add(DataTable[x, 2]);
                item.SubItems.Add(DataTable[x, 3]);
                item.SubItems.Add(DataTable[x, 4]);
                ListViewData.Items.Add(item);
            }
        }

        private void ButtonFillDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            FillArray();
            SortTable();
            DisplayArray();
        }
                private void SortTable()
        {
            for (int x = 1; x < row; x++)
            {
                for (int i = 0; i < row - 1; i++)
                {
                    if (string.Compare(DataTable[i, 0], DataTable[i + 1, 0]) == 1)
                    {
                        Swap(i);
                    }
                }
            }
        }
        private void Swap(int i)
        {
            for (int y = 0; y < col; y++)
            {
                string temp = DataTable[i, y];
                DataTable[i, y] = DataTable[i + 1, y];
                DataTable[i + 1, y] = temp;
            }
        }
    }
}
