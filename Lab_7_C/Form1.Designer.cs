namespace Lab_7_C
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRun = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnIsComplete = new System.Windows.Forms.Button();
            this.btnCallback = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblIsComplete = new System.Windows.Forms.Label();
            this.lblCallback = new System.Windows.Forms.Label();
            this.btnAddSync = new System.Windows.Forms.Button();
            this.btnAddAsyncMI = new System.Windows.Forms.Button();
            this.btnAddAsync = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnAsync = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(40, 62);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Сумма";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.Info;
            this.lblResult.Location = new System.Drawing.Point(137, 62);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(272, 23);
            this.lblResult.TabIndex = 1;
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(98, 22);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 2;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(293, 21);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(20, 19);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(72, 23);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Значение А";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.Location = new System.Drawing.Point(215, 19);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(72, 23);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Значение В";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(13, 23);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "End";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnIsComplete
            // 
            this.btnIsComplete.Location = new System.Drawing.Point(13, 52);
            this.btnIsComplete.Name = "btnIsComplete";
            this.btnIsComplete.Size = new System.Drawing.Size(75, 23);
            this.btnIsComplete.TabIndex = 1;
            this.btnIsComplete.Text = "IsComplete";
            this.btnIsComplete.Click += new System.EventHandler(this.btnIsComplete_Click);
            // 
            // btnCallback
            // 
            this.btnCallback.Location = new System.Drawing.Point(13, 81);
            this.btnCallback.Name = "btnCallback";
            this.btnCallback.Size = new System.Drawing.Size(75, 23);
            this.btnCallback.TabIndex = 2;
            this.btnCallback.Text = "Callback";
            this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.SystemColors.Info;
            this.lblEnd.Location = new System.Drawing.Point(94, 23);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(168, 23);
            this.lblEnd.TabIndex = 3;
            // 
            // lblIsComplete
            // 
            this.lblIsComplete.BackColor = System.Drawing.SystemColors.Info;
            this.lblIsComplete.Location = new System.Drawing.Point(94, 52);
            this.lblIsComplete.Name = "lblIsComplete";
            this.lblIsComplete.Size = new System.Drawing.Size(168, 23);
            this.lblIsComplete.TabIndex = 4;
            // 
            // lblCallback
            // 
            this.lblCallback.BackColor = System.Drawing.SystemColors.Info;
            this.lblCallback.Location = new System.Drawing.Point(94, 81);
            this.lblCallback.Name = "lblCallback";
            this.lblCallback.Size = new System.Drawing.Size(168, 23);
            this.lblCallback.TabIndex = 5;
            // 
            // btnAddSync
            // 
            this.btnAddSync.Location = new System.Drawing.Point(133, 35);
            this.btnAddSync.Name = "btnAddSync";
            this.btnAddSync.Size = new System.Drawing.Size(128, 23);
            this.btnAddSync.TabIndex = 2;
            this.btnAddSync.Text = "Sync";
            this.btnAddSync.Click += new System.EventHandler(this.btnAddSync_Click);
            // 
            // btnAddAsyncMI
            // 
            this.btnAddAsyncMI.Location = new System.Drawing.Point(133, 96);
            this.btnAddAsyncMI.Name = "btnAddAsyncMI";
            this.btnAddAsyncMI.Size = new System.Drawing.Size(128, 23);
            this.btnAddAsyncMI.TabIndex = 1;
            this.btnAddAsyncMI.Text = "Async with MI";
            this.btnAddAsyncMI.Click += new System.EventHandler(this.btnAddAsyncMI_Click);
            // 
            // btnAddAsync
            // 
            this.btnAddAsync.Location = new System.Drawing.Point(133, 64);
            this.btnAddAsync.Name = "btnAddAsync";
            this.btnAddAsync.Size = new System.Drawing.Size(128, 23);
            this.btnAddAsync.TabIndex = 3;
            this.btnAddAsync.Text = "Async";
            this.btnAddAsync.Click += new System.EventHandler(this.btnAsyncAdd_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(67, 96);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHelloWorld.Location = new System.Drawing.Point(64, 35);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(160, 40);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(148, 96);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(75, 23);
            this.btnAsync.TabIndex = 0;
            this.btnAsync.Text = "Async";
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 32);
            this.progressBar1.Maximum = 30000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(144, 196);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Ввод";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(224, 196);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Пуск";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAddSync);
            this.panel1.Controls.Add(this.btnAddAsyncMI);
            this.panel1.Controls.Add(this.btnAddAsync);
            this.panel1.Location = new System.Drawing.Point(12, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 162);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Задание 3";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnEnter);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 246);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Задание 5";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnEnd);
            this.panel3.Controls.Add(this.btnIsComplete);
            this.panel3.Controls.Add(this.btnCallback);
            this.panel3.Controls.Add(this.lblEnd);
            this.panel3.Controls.Add(this.lblIsComplete);
            this.panel3.Controls.Add(this.lblCallback);
            this.panel3.Location = new System.Drawing.Point(482, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 131);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Задание 2";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblA);
            this.panel4.Controls.Add(this.btnRun);
            this.panel4.Controls.Add(this.lblResult);
            this.panel4.Controls.Add(this.txbA);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txbB);
            this.panel4.Controls.Add(this.lblB);
            this.panel4.Location = new System.Drawing.Point(12, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(439, 131);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Задание 1";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblHelloWorld);
            this.panel5.Controls.Add(this.btnAsync);
            this.panel5.Controls.Add(this.btnSync);
            this.panel5.Location = new System.Drawing.Point(482, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 162);
            this.panel5.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Задание 4";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(794, 645);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Асинхронный запуск произвольного метода.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

