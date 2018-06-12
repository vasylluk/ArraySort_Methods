using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySort_Methods
{
    public partial class Form1 : Form
    {

        public long[] arr;
        public long[] arrB;
        public long[] c;
        public string method;

        public Form1()
        {
            InitializeComponent();
        }

        public void ReadFromFile(ListBox l1, long[] array)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 1 || checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Виберіть рівно один метод", "Помилка");
            }
            else
            {
                method = Convert.ToString(checkedListBox1.CheckedItems[0]);
                if (method == "Злиття")
                {
                    label6.Visible = true;
                    BCountUpDown.Visible = true;
                    BFillButton.Visible = true;
                    BListBox.Visible = true;
                    label7.Visible = true;
                    read2Button.Visible = true;
                    ShowBCheckBox.Visible = true;
                    sortButton.Enabled = false;
                    fillButton.Enabled = false;
                }
                else
                {
                    sortButton.Enabled = true;
                    fillButton.Enabled = false;
                }
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            arr = new long[(long)countUpDown.Value];
            if (ShowCheckBox.Checked == true)
            {
                Random r = new Random();
                for (int i = 0; i < countUpDown.Value; i++)
                {
                    arr[i] = r.Next(-1000000000,1000000000);
                }
                listBox1.DataSource = arr;
            }
            else
            {
                Random r = new Random();
                for (int i = 0; i < countUpDown.Value; i++)
                {
                    arr[i] = r.Next(-1000000000, 1000000000);
                }
            }
            confirmButton.Enabled = true;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            double t = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (method == "Швидке")
            {
                watch = System.Diagnostics.Stopwatch.StartNew();
                int left = 0, right = arr.Length - 1; 
                if (left > right || left < 0 || right < 0) return;

                int index = partition(arr, left, right);

                if (index != -1)
                {
                    quickSort(arr, left, index - 1);
                    quickSort(arr, index + 1, right);
                }
                resultListBox.DataSource = arr;
            }

            if (method == "Вставками")
            {
                watch = System.Diagnostics.Stopwatch.StartNew();
                long і, j, newValue;
                for (і = 1; і < arr.Length; і++)
                {
                    newValue = arr[і]; j = і;
                    while (j > 0 && arr[j - 1] > newValue)
                    {
                        arr[j] = arr[j - 1];
                        j--;
                    }
                    arr[j] = newValue;
                }
                resultListBox.DataSource = arr;
            }

            if (method == "Злиття")
            {
                long i, n = 2*arr.Length;
                c = new long[n];
                for (i = 0; i < n/2; i++)
                {
                    if (arr[i] > arrB[i])
                    {
                        c[i + i] = arrB[i];
                        c[i + i + 1] = arr[i];
                    }
                    else
                    {
                        c[i + i] = arr[i];
                        c[i + i + 1] = arrB[i];
                    }
                }
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        long tmp = c[j];
                        if (c[j] > c[k])
                        {
                            c[j] = c[k];
                            c[k] = tmp;
                        }
                    }
                }
                resultListBox.DataSource = c;
            }
            if (method == "Вибіркове")
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    long pos_min = i;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[pos_min])
                        {
                            pos_min = j;
                        }
                    }
                    if (pos_min != i)
                    {
                        long temp = arr[i];
                        arr[i] = arr[pos_min];
                        arr[pos_min] = temp;
                    }
                }
                resultListBox.DataSource = arr;
            }
            if (method == "Шелла")
            {
                long step = arr.Length / 2;
                while (step>0)
                {
                    for (int i = 0; i < arr.Length - step; i++)
                    {
                        int j = i;
                        while (j>=0 && arr[j]>arr[j+step])
                        {
                            long temp = arr[j];
                            arr[j] = arr[j+step];
                            arr[j+step] = temp;
                            j--;
                        }
                    }
                    step /= 2;
                }
                resultListBox.DataSource = arr;
            }
            watch.Stop();
            t = watch.ElapsedMilliseconds;
            if(t>=1)
                timeTextBox.Text = Convert.ToString(t);
            else
                timeTextBox.Text = " <1";
        }

        public static void quickSort(long[] A, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = partition(A, left, right);

            if (index != -1)
            {
                quickSort(A, left, index - 1);
                quickSort(A, index + 1, right);
            }
        }

        private static void swap(long[] A, int left, int right)
        {
            long tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }


        private static int partition(long[] A, int left, int right)
        {
            if (left > right) return -1;
            int end = left;
            long p = A[right];
            for (int i = left; i < right; i++)
            {
                if (A[i] < p)
                {
                    swap(A, i, end);
                    end++;
                }
            }
            swap(A, end, right);
            return end;
        }

        private void BFillButton_Click(object sender, EventArgs e)
        {
            arrB = new long[(long)BCountUpDown.Value];
            if (arr.Length != arrB.Length)
            {
                MessageBox.Show("Масиви неодинакової розмірності", "Помилка");
            }
            if (ShowBCheckBox.Checked == true)
            {
                Random r = new Random();
                for (int i = 0; i < BCountUpDown.Value; i++)
                {
                    arrB[i] = r.Next(-1000000000, 1000000000);
                }
                BListBox.DataSource = arrB;
            }
            else
            {
                Random r = new Random();
                for (int i = 0; i < BCountUpDown.Value; i++)
                {
                    arrB[i] = r.Next(-1000000000, 1000000000);
                }
            }
            sortButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void read1Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {

                    string[] words = Regex.Split(r.ReadToEnd(), @"\s+");
                    arr = new long[(long)words.Length];
                    for (int i = 0; i < words.Length; i++)
                    {
                        arr[i] = Convert.ToInt64(words[i]);
                    }
                    listBox1.DataSource = arr;
                }
            }
            fillButton.Enabled = false;
            confirmButton.Enabled = true;
        }

        private void read2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                BListBox.Items.Clear();
                using (StreamReader r = new StreamReader(f1.OpenFile()))
                {
                    string[] words1 = Regex.Split(r.ReadToEnd(), @"\s+");
                    arrB = new long[(long)words1.Length];
                    for (int i = 0; i < words1.Length; i++)
                    {
                        arrB[i] = Convert.ToInt64(words1[i]);
                    }
                    BListBox.DataSource = arrB;
                }
            }
            BFillButton.Enabled = false;
            confirmButton.Enabled = true;
            sortButton.Enabled = true;
        }
    }
}
