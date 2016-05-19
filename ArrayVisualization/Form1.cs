using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayVisualization
{
    public partial class Form1 : Form
    {

        //THERE ARE NO COMMENTS HAHAHAHA!!!
        Graphics drawArea;
        const int arrSize = 40;
        int[] arr = new int[arrSize];

        public Form1()
        {
            InitializeComponent();
            drawArea = drawingArea.CreateGraphics();
            arr = fillArray(arr);
        }

        private void drawArray_Click(object sender, EventArgs e)
        {
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;
            int padding = 0;

            drawArea.Clear(drawingArea.BackColor);
            for (int i = 0; i < arr.Length; i++)
            {
                Rectangle rectDraw = new Rectangle((i + padding), drawHeight - arr[i], 10, drawHeight);
                drawArea.FillRectangle(Brushes.Black, rectDraw);
                padding += (drawWidth / arrSize);
            }
        }

        private void shuffleArrayBtn_Click(object sender, EventArgs e)
        {
            drawArea.Clear(drawingArea.BackColor);
            arr = shuffleArray(arr);
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;
            int padding = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Rectangle rectDraw = new Rectangle((i + padding), drawHeight - arr[i], 10, drawHeight);
                drawArea.FillRectangle(Brushes.Black, rectDraw);
                padding += (drawWidth / arrSize);
            }

        }

        private void insertSortBtn_Click(object sender, EventArgs e)
        {
            drawArea.Clear(drawingArea.BackColor);
            insertionSort(ref arr);
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;
            int padding = 0;

            drawArea.Clear(drawingArea.BackColor);
            for (int i = 0; i < arr.Length; i++)
            {
                Rectangle rectDraw = new Rectangle((i + padding), drawHeight - arr[i], 10, drawHeight);
                drawArea.FillRectangle(Brushes.Black, rectDraw);
                padding += (drawWidth / arrSize);
            }
            
        }

        private void selectSortBtn_Click(object sender, EventArgs e)
        {
            drawArea.Clear(drawingArea.BackColor);
            selectionSort(ref arr);
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;
            int padding = 0;

            drawArea.Clear(drawingArea.BackColor);
            for (int i = 0; i < arr.Length; i++)
            {
                Rectangle rectDraw = new Rectangle((i + padding), drawHeight - arr[i], 10, drawHeight);
                drawArea.FillRectangle(Brushes.Black, rectDraw);
                padding += (drawWidth / arrSize);
            }
        }

        private int[] fillArray(int[] array)
        {
            int extraLength = 0;
            for(int i = 1; i < array.Length+1; i++)
            {
                extraLength += 10;
                array[i-1] = i+extraLength;
            }
            return array;
        }

        private int[] shuffleArray(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }

        private void insertionSort(ref int[] array)
        {
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;

            for (int i = 1; i < array.Length; i++)
            {
                int padding = 0;

                int x = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > x)
                {
                    int padding2 = 0;
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (k == j || k == i)
                        {
                            Rectangle rectDraw = new Rectangle((k + padding2), drawHeight - arr[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Red, rectDraw);
                            padding2 += (drawWidth / arrSize);
                        }
                        else
                        {
                            Rectangle rectDraw = new Rectangle((k + padding2), drawHeight - arr[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Black, rectDraw);
                            padding2 += (drawWidth / arrSize);
                        }
                    }
                    System.Threading.Thread.Sleep(25);
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                drawArea.Clear(drawingArea.BackColor);
                for (int k = 0; k < arr.Length; k++)
                {
                    if (k == i)
                    {
                        Rectangle rectDraw = new Rectangle((k + padding), drawHeight - arr[k], 10, drawHeight);
                        drawArea.FillRectangle(Brushes.Red, rectDraw);
                    }
                    else
                    {
                        Rectangle rectDraw = new Rectangle((k + padding), drawHeight - arr[k], 10, drawHeight);
                        drawArea.FillRectangle(Brushes.Black, rectDraw);

                    }
                    padding += (drawWidth / arrSize);
                }
                array[j + 1] = x;
                System.Threading.Thread.Sleep(100);
            }
        }

        private void selectionSort(ref int[] arr)
        {
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;

            int i, j;
            for(j = 0; j < arr.Length; j++)
            {
                int padding = 0;
                int iMin = j;
                for(i = j+1; i < arr.Length; i++)
                {
                    if(arr[i] < arr[iMin])
                    {
                        iMin = i;
                    }
                }
                if(iMin != j)
                {
                    drawArea.Clear(drawingArea.BackColor);
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (k == iMin || k == j)
                        {
                            Rectangle rectDraw = new Rectangle((k + padding), drawHeight - arr[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Red, rectDraw);
                        }
                        else
                        {
                            Rectangle rectDraw = new Rectangle((k + padding), drawHeight - arr[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Black, rectDraw);

                        }
                        padding += (drawWidth / arrSize);
                    }
                    System.Threading.Thread.Sleep(200);

                    int temp = arr[iMin];
                    arr[iMin] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        private void quickSortBtn_Click(object sender, EventArgs e)
        {
            drawArea.Clear(drawingArea.BackColor);
            QuickSort_Recursive(arr, 0, arr.Length - 1);
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;
            int padding = 0;

            drawArea.Clear(drawingArea.BackColor);
            for (int i = 0; i < arr.Length; i++)
            {
                Rectangle rectDraw = new Rectangle((i + padding), drawHeight - arr[i], 10, drawHeight);
                drawArea.FillRectangle(Brushes.Black, rectDraw);
                padding += (drawWidth / arrSize);
            }
        }

        private int Partition(int[] numbers, int left, int right)
        {
            int drawHeight = drawingArea.Height;
            int drawWidth = drawingArea.Width;

            int pivot = numbers[left];
            while (true)
            {
                int padding = 0;
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    drawArea.Clear(drawingArea.BackColor);
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (k == right || k == left)
                        {
                            Rectangle rectDraw = new Rectangle((k + padding), drawHeight - numbers[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Red, rectDraw);
                        }
                        else if(k > left && k < right)
                        {
                            Rectangle rectDraw = new Rectangle((k + padding), drawHeight - numbers[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Green, rectDraw);
                        }
                        else
                        {
                            Rectangle rectDraw = new Rectangle((k + padding), drawHeight - numbers[k], 10, drawHeight);
                            drawArea.FillRectangle(Brushes.Black, rectDraw);

                        }
                        padding += (drawWidth / arrSize);
                    }
                    System.Threading.Thread.Sleep(150);
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        private void QuickSort_Recursive(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
