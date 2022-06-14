using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            data.Revenue.Clear();
            data.Revenue.Rows.Add("신라면", 20);
            data.Revenue.Rows.Add("진라면", 10);
            data.Revenue.Rows.Add("너구리", 5);
            data.Revenue.Rows.Add("꼬꼬면", 3);
            data.Revenue.Rows.Add("참깨라면", 7);       
            data.Revenue.Rows.Add("불닭볶음면", 16);
            data.Revenue.Rows.Add("안성탕면", 9);
            data.Revenue.Rows.Add("삼양라면", 3);
            data.Revenue.Rows.Add("짜파게티", 2);
            data.Revenue.Rows.Add("사리곰탕", 1);
            data.Revenue.Rows.Add("튀김우동", 5);

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Revenue) series.Add(new PieSeries()
            {
                Title = obj.항목.ToString(),
                Values = new ChartValues<int>
                { obj.Total }
            });
            pieChart1.Series = series;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            data.Revenue.Clear();
            data.Revenue.Rows.Add("0~1번", 10);
            data.Revenue.Rows.Add("1번", 25);
            data.Revenue.Rows.Add("2번", 7);
            data.Revenue.Rows.Add("3번이상", 2);
            data.Revenue.Rows.Add("잘모르겠다", 5);

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Revenue) series.Add(new PieSeries()
            {
                Title = obj.항목.ToString(),
                Values = new ChartValues<int>
                { obj.Total }
            });
            pieChart1.Series = series;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            data.Revenue.Clear();
            data.Revenue.Rows.Add("참치", 5);
            data.Revenue.Rows.Add("스팸", 10);
            data.Revenue.Rows.Add("계란", 30);
            data.Revenue.Rows.Add("파", 10);
            data.Revenue.Rows.Add("고추", 10);
            data.Revenue.Rows.Add("김치", 4);
            data.Revenue.Rows.Add("떡", 3);
            data.Revenue.Rows.Add("치즈", 7);
            data.Revenue.Rows.Add("양파", 4);
            data.Revenue.Rows.Add("않넣어먹는다", 5);
            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Revenue) series.Add(new PieSeries()
            {
                Title = obj.항목.ToString(),
                Values = new ChartValues<int>
                { obj.Total }
            });
            pieChart1.Series = series;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            data.Revenue.Clear();
            data.Revenue.Rows.Add("네", 7);
            data.Revenue.Rows.Add("아니요", 2);
            data.Revenue.Rows.Add("잘모르겠다", 5);

            SeriesCollection series = new SeriesCollection();
            foreach (var obj in data.Revenue) series.Add(new PieSeries()
            {
                Title = obj.항목.ToString(),
                Values = new ChartValues<int>
                { obj.Total }
            });
            pieChart1.Series = series;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
       
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
