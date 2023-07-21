using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDiff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            var dataSet1 = GetDataSet1();
            var dataSet2 = GetDataSet2();
            var result1 = dataSet1.Except(dataSet2);
            var result2 = dataSet2.Except(dataSet1);
            TxtResult1.Text = string.Join("\r\n", result1);
            TxtResult2.Text = string.Join("\r\n", result2);
        }

        private List<string> GetDataSet1()
        {
            var content = TxtDataSet1.Text;
            return GetMultiLineText(content);
        }

        private List<string> GetDataSet2()
        {
            var content = TxtDataSet2.Text;
            return GetMultiLineText(content);
        }

        private List<string> GetMultiLineText(string content)
        {
            return Regex.Split(content, "\r\n", RegexOptions.IgnoreCase)
                .Where(s => string.Empty != s)
                .ToList();
        }
    }
}