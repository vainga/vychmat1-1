using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace vychmat1_1
{

    public partial class Form1 : Form
    {
        public float epsilon = 0.01f;
        public List<(float Left, float Right)> intervals;
        public List<float> res;
        public enum FType { FIRST = 0, SECOND };
        FType type = FType.FIRST;

        public Form1()
        {
            InitializeComponent();
            Setup();
            DrawChart();
        }

        public void Setup()
        {
            epsilonLabel.Text = epsilon.ToString();
            panelXY.Legends[0].Enabled = false;

            panelXY.ChartAreas[0].AxisX.LabelStyle.Format = "0.000";
            panelXY.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            //panelXY.ChartAreas[0].AxisX.Interval = 10;///////////////////////////////////////

            panelXY.ChartAreas[0].Axes[0].LineWidth = 2;
            panelXY.ChartAreas[0].Axes[0].Crossing = 0;
            panelXY.ChartAreas[0].Axes[0].IsMarksNextToAxis = false;
            panelXY.ChartAreas[0].Axes[1].LineWidth = 2;
            panelXY.ChartAreas[0].Axes[1].Crossing = 0;
            panelXY.ChartAreas[0].Axes[1].IsMarksNextToAxis = false;
            panelXY.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        // функции для графиков и 1 и 2 производных //////////////////////////// 

        public float Func(float x)
        {
            if (type == FType.FIRST) return (float)Math.Pow(2, x) - 5 * x * x + 10;
            else return 100 * x * x - 10000 * x - 2;
        }

        public float DFunc(float x)
        {
            if (type == FType.FIRST) return (float)(Math.Pow(2, x) * Math.Log(2)) - 10 * x;
            else return 200 * x - 10000;
        }

        public float DDFunc(float x)
        {
            if (type == FType.FIRST) return (float)(Math.Pow(2, x) * Math.Log(2) * Math.Log(2)) - 10;
            else return 200;
        }

        //////////////////////////////////////////////////

        public void DrawChart()
        {
            if (type == FType.FIRST) intervals = new List<(float, float)> { (-2.0f, -1.0f), (1.0f, 2.0f), (8.0f, 9.0f) };
            else intervals = new List<(float, float)> { (-1.0f, 0.0f), (100.0f, 101.0f) };

            panelXY.ChartAreas[0].AxisX.Minimum = intervals[0].Left;
            panelXY.ChartAreas[0].AxisX.Maximum = intervals.Last().Right;
            for (float x = intervals[0].Left; x < intervals.Last().Right; x += 0.2f)
            {
                panelXY.Series[0].Points.AddXY(x, Func(x));
            }
        }

        private void newtonButton_MouseClick(object sender, MouseEventArgs e)
        {
            res = new List<float>();
            rootCount.Text = "0";
            roots.Items.Clear();
            promZnach.Items.Clear();

            // метод Ньютона
            float x, x0;
            int Count = 0;
            int allC = 0;

            for (int i = 0; i < intervals.Count; i++)
            {
                //x = intervals[i].Right;
                //x0 = Func(x) / DFunc(x);

                x = intervals[i].Right;

                x0 = Func(x) / DFunc(x);

                int count = 0;
                Count = 0;

                while (Math.Abs(x0 - x) > epsilon)
                {
                    count++;
                    Count++;
                    allC++;
                    x0 = x;
                    x -= Func(x) / DFunc(x);
                    if (count == 1000)
                    {
                        x0 = intervals[i].Left;
                    }
                    promZnach.Items.Add(x);
                }

                res.Add(x);
                rootCount.Text = res.Count.ToString();
                roots.Items.Add((Math.Round(x, (int)Math.Abs(Math.Log10(epsilon)))).ToString() + " - " + Count + " итераций");
            }
            roots.Items.Add(allC + " Общее кол-во итераций");
            
        }

        private void simpleButton_MouseClick(object sender, MouseEventArgs e)
        {
            res = new List<float>();
            rootCount.Text = "0";
            roots.Items.Clear();
            // метод простых итераций
            promZnach.Items.Clear();
            float a, b, lambda, x, x0;
            int Count = 0;
            int allC = 0;

            for (int i = 0; i < intervals.Count; i++)
            {
                a = intervals[i].Left;
                b = intervals[i].Right;

                if (Math.Max(DFunc(a), DFunc(b)) > 0) lambda = -1 / Math.Abs(Math.Max(DFunc(a), DFunc(b)));
                else lambda = 1 / Math.Abs(Math.Max(DFunc(a), DFunc(b)));
                x = (a + b) / 2;
                x0 = 0;

                Count = 0;
                if(Math.Max(DFunc(a), DFunc(b)) < 1 / 2)
                    while (Math.Abs(x0 - x) > epsilon)
                    {
                        Count++;
                        allC++;
                        x0 = x;
                        x += lambda * (Func(x));
                        promZnach.Items.Add(x);
                    }
                else if(Math.Max(DFunc(a), DFunc(b)) > 1 / 2)
                    while (Math.Abs(x0 - x) > ((Math.Max(DFunc(a), DFunc(b) - 1) / Math.Max(DFunc(a), DFunc(b)) * epsilon)))
                    {
                        Count++;
                        allC++;
                        x0 = x;
                        x += lambda * (Func(x));
                        promZnach.Items.Add(x);
                    }

                res.Add(x);
                rootCount.Text = res.Count.ToString();
                roots.Items.Add((Math.Round(x, (int)Math.Abs(Math.Log10(epsilon)))).ToString() + " - " + Count + " итераций");
            }
            roots.Items.Add(allC + " Общее кол-во итераций");

        }

        private void hordeButton_MouseClick(object sender, MouseEventArgs e)
        {
                        res = new List<float>();
            rootCount.Text = "0";
            roots.Items.Clear();
            promZnach.Items.Clear();

            float xmark;
            float x0;
            float xi;
            float a, b;
            int Count = 0;
            int allC = 0;
            for (int i = 0; i < intervals.Count; i++)
            {
                a = intervals[i].Left;
                b = intervals[i].Right;
                x0 = (-Func(a)) * (b - a) / (Func(b) - Func(a)) + a;      
                if (Math.Sign(DDFunc(a)) == Math.Sign(Func(a))) xmark = a;
                else xmark = b;
                xi = (-Func(xmark)) * (x0 - xmark) / (Func(x0) - Func(xmark)) + xmark;
                Count = 0;
                while (Math.Abs(xi - x0) > epsilon)
                {
                    Count++;
                    allC++;
                    x0 = xi;
                    xi = (-Func(xmark)) * (x0 - xmark) / (Func(x0) - Func(xmark)) + xmark;
                    promZnach.Items.Add(xi);

                }
                res.Add(xi);
                rootCount.Text = res.Count.ToString();
                roots.Items.Add((Math.Round(xi, (int)Math.Abs(Math.Log10(epsilon)))).ToString() + " - " + Count + " итераций");
            }
            roots.Items.Add(allC + " Общее кол-во итераций");
        }

        private void expFuncButton_MouseClick(object sender, MouseEventArgs e)
        {
            panelXY.Series[0].Points.Clear();
            type = FType.FIRST;
            DrawChart();
            res = new List<float>();
            rootCount.Text = "0";
            roots.Items.Clear();
        }

        private void quaDFuncButton_MouseClick(object sender, MouseEventArgs e)
        {
            panelXY.Series[0].Points.Clear();
            type = FType.SECOND;
            DrawChart();
            res = new List<float>();
            rootCount.Text = "0";
            roots.Items.Clear();
        }
    }



}
