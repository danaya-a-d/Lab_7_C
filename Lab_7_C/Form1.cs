using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab_7_C
{
    public partial class Form1 : Form
    {
        private Button btnRun;
        private Label lblResult;
        private TextBox txbA;
        private TextBox txbB;
        private Label lblA;
        private Label lblB;

        private Button btnEnd;
        private Button btnIsComplete;
        private Button btnCallback;
        private Label lblEnd;
        private Label lblIsComplete;
        private Label lblCallback;

        private Button btnAddSync;
        private Button btnAddAsyncMI;
        private Button btnAddAsync;

        private Button btnSync;
        private Label lblHelloWorld;
        private Button btnAsync;

        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Button btnEnter;
        private Button btnStart;
        private PictureBox pictureBox1;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = int.Parse(txbA.Text);
                b = int.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            // Создаем экземпляр summdelegate делегата AsyncSumm и инициализируем  его  методом Summ
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            // Создаем экземпляр cb  делегата AsyncCallback для завершения вызова.
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            // Запускаем асинхронно метод, прикрепленный к делегату summdelegate
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        //метод, в котором будут складываться числа, вводимые в два текстовых поля
        private int Summ(int a, int b)
        {
            return a + b;
        }

        /// Делегат, принимающий две переменные типа int и возвращающий одну переменную типа int,
        /// для асинхронного запуска метода (Summ)
        private delegate int AsyncSumm(int a, int b);

        /// Метод для завершения асинхронного вызова.
        /// <param name="ar"></param>
        private void CallBackMethod(IAsyncResult ar)
        {
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            // lblResult.Text = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            TolblResult(string.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar)));
        }

        // InvokeRequired для добавления текста на lblResult
        private void TolblResult(string text)
        {
            if (InvokeRequired)
                Invoke((Action<string>)TolblResult, text);
            else
                lblResult.Text = text;
        }
        
        


        /////////////////////////// Задание 2 ///////////////////////////


        private void btnEnd_Click(object sender, EventArgs e)
        {
            AsynchronousMethodDelegate asyncDeleg = new
                AsynchronousMethodDelegate(AsynchronousMethod);
            // Запускаем асинхронно метод AsynchronousMethod.
            IAsyncResult ar = asyncDeleg.BeginInvoke(ActivateType.End, null, null);
            // Получаем  результаты асинхронного метода.
            lblEnd.Text = asyncDeleg.EndInvoke(ar);
        }

        private void btnIsComplete_Click(object sender, EventArgs e)
        {
            AsynchronousMethodDelegate asyncDeleg = new
                AsynchronousMethodDelegate(AsynchronousMethod);
            // Запускаем асинхронно метод AsynchronousMethod.
            IAsyncResult ar = asyncDeleg.BeginInvoke(ActivateType.IsColplete, null, null);
            while (!ar.IsCompleted)
            {
                lblIsComplete.Text = "Ожидание";
            }
            // Получаем  результаты асинхронного метода.
            lblIsComplete.Text = asyncDeleg.EndInvoke(ar);
        }

        private void btnCallback_Click(object sender, EventArgs e)
        {
            AsynchronousMethodDelegate asyncDeleg = new
                AsynchronousMethodDelegate(AsynchronousMethod);
            // Создаем экземпляр callback  делегата Callback.
            AsyncCallback callback = new AsyncCallback(CallbackMethod);
            // Запускаем асинхронно метод AsynchronousMethod.
            asyncDeleg.BeginInvoke(ActivateType.Callback, callback, asyncDeleg);
        }

        /// Создаем метод для завершения асинхронного вызова с использованием callback
        /// <param name="ar"></param>
        private void CallbackMethod(IAsyncResult ar)
        {
            // Приводим  к типу AsynchronousMethodDelegate
            AsynchronousMethodDelegate asyncDeleg = (AsynchronousMethodDelegate)ar.AsyncState;
            // Получаем  результаты асинхронного метода.

            //lblCallback.Text = asyncDeleg.EndInvoke(ar);
            TolblCallback(asyncDeleg.EndInvoke(ar));
        }

        // InvokeRequired для добавления текста на lblCallback
        private void TolblCallback(string text)
        {
          if (InvokeRequired)
            Invoke((Action<string>)TolblCallback, text);
          else
            lblCallback.Text = text;
         }

    private delegate string AsynchronousMethodDelegate(ActivateType source);

        /// Создаем метод, предназначенный для асинхронного запуска.
        /// <param name="source">Тип завершения метода.</param>
        private string AsynchronousMethod(ActivateType source)
        {
            string result = String.Empty;
            switch (source)
            {
                case ActivateType.Callback:
                    result = "Callback";
                    break;
                case ActivateType.End:
                    result = "End";
                    break;
                case ActivateType.IsColplete:
                    result = "Is Complete";
                    break;
            }
            return result;
        }

        /// Тип завершения асинхронного вызова.
        private enum ActivateType
        {
            End,
            IsColplete,
            Callback
        }




        /////////////////////////// Задание 3 ///////////////////////////

        /*
         При нажатии кнопки Sync кнопка появляется 
         самым обычным способом — в ее обработчике просто вызывается метод UpdateUI.
         В обработчиках кнопок Async и Async with MI вызывается метод UpdateUI, 
         только в первом случае элемент создается не в основном потоке,
         поэтому не происходит обновления пользовательского интерфейса, а во втором 
         случае элемент возвращается в основной поток – и кнопка появляется на форме.
         */

        private void btnAddSync_Click(object sender, EventArgs e)
        {
            // Синхронный запуск метода UpdateUI
            UpdateUI();
        }

        // Делегат для вызова метода UpdateUI асинхронно.
        delegate void AddItemAsyncDelegate();

        private void btnAddAsyncMI_Click(object sender, EventArgs e)
        {
            // Асинхронный вызов метода UpdateAsync
            AddItemAsyncDelegate asyncDel = new AddItemAsyncDelegate(UpdateAsync);
            asyncDel.BeginInvoke(null, null);
        }
        private void UpdateAsync()
        {
            // Асинхронный вызов метода UpdateUI
            MethodInvoker methodinvoker = new MethodInvoker(UpdateUI);
            this.BeginInvoke(methodinvoker);
        }
        private void UpdateUI()
        {
            // Добавление элемента управления.
            Button btn = new Button();
            btn.Text = "Кнопка";

            //this.Controls.Add(btn);
            ToAddBtn(btn);
        }

        // InvokeRequired для добавления кнопки на форму
        private void ToAddBtn(Button b)
        {
            if (InvokeRequired)
                Invoke((Action<Button>)ToAddBtn, b);
            else
                this.Controls.Add(b);
        }

        private void btnAsyncAdd_Click(object sender, EventArgs e)
        {
            // Асинхронный вызов метода UpdateUI
            AddItemAsyncDelegate asyncDel = new AddItemAsyncDelegate(UpdateUI);
            asyncDel.BeginInvoke(null, null);
        }




        /////////////////////////// Задание 4 ///////////////////////////
        
        private void btnSync_Click(object sender, EventArgs e)
        {

            // Деактивируем кнопку.
            btnSync.Enabled = false;
            // Создаем  экземпляр Web-службы

            WebServise.WebService1SoapClient service = new WebServise.WebService1SoapClient();
            // Запуск метода
            lblHelloWorld.Text = service.HelloWorld();
            ToLabel(service.HelloWorld());
            // Активируем  кнопку.
            btnSync.Enabled = true;
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            // Деактивируем кнопку.
            btnAsync.Enabled = false;
            // Создаем  экземпляр Web-службы
            WebServise.WebService1SoapClient service = new WebServise.WebService1SoapClient();
            // Запуск метода асинхронно
            service.HelloWorldAsync();
        }
        private void AsyncCallBackMethod(IAsyncResult ar)
        {
            WebServise.WebService1SoapClient service = (WebServise.WebService1SoapClient)ar.AsyncState;
            //lblHelloWorld.Text = service.EndHelloWorld(ar);
            ToLabel(service.HelloWorld());
            // Активируем  кнопку.
            btnAsync.Enabled = true;
        }

        private void ToLabel(string text)
        {
            if (InvokeRequired)
                Invoke((Action<string>)ToLabel, text);
            else
                lblHelloWorld.Text = text;
        }



        /////////////////////////// Задание 5 ///////////////////////////

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                return;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            for (int i = 0; i < 30000; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}
