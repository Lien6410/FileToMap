using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FileToMap
{
    public class Wrapper
    {
        private static Wrapper wrapper;
        private static object theLock = new object();
        public const double InitialMin = 10000;
        public string SrcFileFullPath { get; set; }
        public string SaveNameWithShift { get; private set; }
        public double MinX { get; private set; } = 10000;
        public double MinY { get; private set; } = 10000;
        public List<OneRowData> rowDatas;

        public Wrapper()
        {
            rowDatas = new List<OneRowData>();
        }

        public static Wrapper GetInstance()
        {
            if (wrapper == null)
            {
                lock (theLock)
                {
                    if (wrapper == null)
                    {
                        wrapper = new Wrapper();
                    }
                }
            }

            return wrapper;
        }

        public void LoadTxtFile()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SrcFileFullPath))
                {
                    return;
                }

                rowDatas.Clear();

                string[] allRows = File.ReadAllLines(SrcFileFullPath);
                if (allRows == null || allRows.Length < 2)
                {
                    return;
                }
                allRows = allRows.Skip(1).ToArray();//skip header

                string[] firstRow = allRows[0].Split(',');

                int nRows = allRows.Length;
                int nColumns = firstRow.Length;

                for (int i = 0; i < nRows; i++)
                {
                    string[] getThisRow = allRows[i].Split(',');
                    OneRowData oneRowData = new OneRowData
                    {
                        plan_x = getThisRow[3],
                        plan_y = getThisRow[4],
                        plan_value = getThisRow[5]
                    };
                    rowDatas.Add(oneRowData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void TxtIntoChart()
        {
            try
            {
                ChartForm chartForm = new ChartForm();
                var myChart = chartForm.chart1;
                //double minX = 10000;
                //double minY = 10000;
                foreach (var oneRowData in rowDatas)
                {
                    int getSeries = int.Parse(oneRowData.plan_value);
                    if (getSeries < 0 || getSeries > 20)
                    {
                        Console.WriteLine();
                    }
                    double getX = double.Parse(oneRowData.plan_x);
                    double getY = double.Parse(oneRowData.plan_y);
                    if (getX < MinX) MinX = getX;
                    if (getY < MinY) MinY = getX;
                    myChart.Series[getSeries].Points.AddXY(getX, getY);
                }
                SignofXY signofX = SignofXY.P;
                if (MinX < 0)
                {
                    signofX = SignofXY.N;
                    MinX = -MinX;
                }
                SignofXY signofY = SignofXY.P;
                if (MinY < 0)
                {
                    signofY = SignofXY.N;
                    MinY = -MinY;
                }

                myChart.ChartAreas[0].RecalculateAxesScale();

                string destFileSaveName = Path.GetFileNameWithoutExtension(SrcFileFullPath);
                destFileSaveName += "_" + signofX.ToString() + MinX.ToString("00000") + signofY.ToString() + MinY.ToString("00000");// + ".png";

                SaveNameWithShift = destFileSaveName;
                
                chartForm.ResetImageAndPb();                

                chartForm.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
