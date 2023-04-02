namespace MonteCarloAsync
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb_sep = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.CheckL = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_BFGSFopt_Async = new System.Windows.Forms.TextBox();
            this.CopyLocalXoptAync = new System.Windows.Forms.Button();
            this.lb_BFGSXopt = new System.Windows.Forms.ListBox();
            this.CopyXoptSync = new System.Windows.Forms.Button();
            this.CopyXoptAsync = new System.Windows.Forms.Button();
            this.tb_Fopt_Async = new System.Windows.Forms.TextBox();
            this.tB_iter = new System.Windows.Forms.TextBox();
            this.tb_TimeSync = new System.Windows.Forms.TextBox();
            this.tb_Fopt_Sync = new System.Windows.Forms.TextBox();
            this.tB_dimension = new System.Windows.Forms.TextBox();
            this.tb_TimeAsync = new System.Windows.Forms.TextBox();
            this.tB_repeat = new System.Windows.Forms.TextBox();
            this.lb_Xn_opt_Sync = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Xn_opt_Async = new System.Windows.Forms.ListBox();
            this.cb_func = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_MonteCarlo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.CheckL);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tb_BFGSFopt_Async);
            this.tabPage2.Controls.Add(this.CopyLocalXoptAync);
            this.tabPage2.Controls.Add(this.lb_BFGSXopt);
            this.tabPage2.Controls.Add(this.CopyXoptSync);
            this.tabPage2.Controls.Add(this.CopyXoptAsync);
            this.tabPage2.Controls.Add(this.tb_Fopt_Async);
            this.tabPage2.Controls.Add(this.tB_iter);
            this.tabPage2.Controls.Add(this.tb_TimeSync);
            this.tabPage2.Controls.Add(this.tb_Fopt_Sync);
            this.tabPage2.Controls.Add(this.tB_dimension);
            this.tabPage2.Controls.Add(this.tb_TimeAsync);
            this.tabPage2.Controls.Add(this.tB_repeat);
            this.tabPage2.Controls.Add(this.lb_Xn_opt_Sync);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lb_Xn_opt_Async);
            this.tabPage2.Controls.Add(this.cb_func);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_MonteCarlo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Параллельный метод Монте-Карло";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb_sep
            // 
            this.rb_sep.AutoSize = true;
            this.rb_sep.Location = new System.Drawing.Point(6, 42);
            this.rb_sep.Name = "rb_sep";
            this.rb_sep.Size = new System.Drawing.Size(275, 17);
            this.rb_sep.TabIndex = 53;
            this.rb_sep.TabStop = true;
            this.rb_sep.Text = "Метод Монте-Карло для сепарабельных функции";
            this.rb_sep.UseVisualStyleBackColor = true;
            this.rb_sep.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Выбор режимов работы:";
            // 
            // CheckL
            // 
            this.CheckL.CheckOnClick = true;
            this.CheckL.FormattingEnabled = true;
            this.CheckL.Items.AddRange(new object[] {
            "Sync",
            "Async"});
            this.CheckL.Location = new System.Drawing.Point(552, 26);
            this.CheckL.Name = "CheckL";
            this.CheckL.Size = new System.Drawing.Size(146, 34);
            this.CheckL.TabIndex = 49;
            this.CheckL.SelectedIndexChanged += new System.EventHandler(this.CheckL_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 311);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "X(n) opt BFGS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "BFGS";
            // 
            // tb_BFGSFopt_Async
            // 
            this.tb_BFGSFopt_Async.Location = new System.Drawing.Point(351, 270);
            this.tb_BFGSFopt_Async.Margin = new System.Windows.Forms.Padding(2);
            this.tb_BFGSFopt_Async.Name = "tb_BFGSFopt_Async";
            this.tb_BFGSFopt_Async.ReadOnly = true;
            this.tb_BFGSFopt_Async.Size = new System.Drawing.Size(168, 20);
            this.tb_BFGSFopt_Async.TabIndex = 45;
            // 
            // CopyLocalXoptAync
            // 
            this.CopyLocalXoptAync.Location = new System.Drawing.Point(351, 461);
            this.CopyLocalXoptAync.Name = "CopyLocalXoptAync";
            this.CopyLocalXoptAync.Size = new System.Drawing.Size(168, 41);
            this.CopyLocalXoptAync.TabIndex = 44;
            this.CopyLocalXoptAync.Text = "Скопировать BFGSXopt_Async";
            this.CopyLocalXoptAync.UseVisualStyleBackColor = true;
            this.CopyLocalXoptAync.Click += new System.EventHandler(this.btn_CopyBFGSXoptAync_Click);
            // 
            // lb_BFGSXopt
            // 
            this.lb_BFGSXopt.FormattingEnabled = true;
            this.lb_BFGSXopt.Location = new System.Drawing.Point(351, 336);
            this.lb_BFGSXopt.Name = "lb_BFGSXopt";
            this.lb_BFGSXopt.Size = new System.Drawing.Size(168, 108);
            this.lb_BFGSXopt.TabIndex = 43;
            // 
            // CopyXoptSync
            // 
            this.CopyXoptSync.Location = new System.Drawing.Point(558, 461);
            this.CopyXoptSync.Name = "CopyXoptSync";
            this.CopyXoptSync.Size = new System.Drawing.Size(168, 41);
            this.CopyXoptSync.TabIndex = 42;
            this.CopyXoptSync.Text = "Скопировать Xopt_Sync";
            this.CopyXoptSync.UseVisualStyleBackColor = true;
            this.CopyXoptSync.Click += new System.EventHandler(this.btn_CopyXoptSync_Click);
            // 
            // CopyXoptAsync
            // 
            this.CopyXoptAsync.Location = new System.Drawing.Point(144, 461);
            this.CopyXoptAsync.Name = "CopyXoptAsync";
            this.CopyXoptAsync.Size = new System.Drawing.Size(168, 41);
            this.CopyXoptAsync.TabIndex = 41;
            this.CopyXoptAsync.Text = "Скопировать Xopt_Async";
            this.CopyXoptAsync.UseVisualStyleBackColor = true;
            this.CopyXoptAsync.Click += new System.EventHandler(this.btn_CopyXoptAsync_Click);
            // 
            // tb_Fopt_Async
            // 
            this.tb_Fopt_Async.Location = new System.Drawing.Point(144, 270);
            this.tb_Fopt_Async.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Fopt_Async.Name = "tb_Fopt_Async";
            this.tb_Fopt_Async.ReadOnly = true;
            this.tb_Fopt_Async.Size = new System.Drawing.Size(168, 20);
            this.tb_Fopt_Async.TabIndex = 16;
            // 
            // tB_iter
            // 
            this.tB_iter.Location = new System.Drawing.Point(187, 63);
            this.tB_iter.Name = "tB_iter";
            this.tB_iter.Size = new System.Drawing.Size(135, 20);
            this.tB_iter.TabIndex = 35;
            // 
            // tb_TimeSync
            // 
            this.tb_TimeSync.Location = new System.Drawing.Point(558, 220);
            this.tb_TimeSync.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TimeSync.Name = "tb_TimeSync";
            this.tb_TimeSync.ReadOnly = true;
            this.tb_TimeSync.Size = new System.Drawing.Size(168, 20);
            this.tb_TimeSync.TabIndex = 29;
            // 
            // tb_Fopt_Sync
            // 
            this.tb_Fopt_Sync.Location = new System.Drawing.Point(558, 270);
            this.tb_Fopt_Sync.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Fopt_Sync.Name = "tb_Fopt_Sync";
            this.tb_Fopt_Sync.ReadOnly = true;
            this.tb_Fopt_Sync.Size = new System.Drawing.Size(168, 20);
            this.tb_Fopt_Sync.TabIndex = 22;
            // 
            // tB_dimension
            // 
            this.tB_dimension.Location = new System.Drawing.Point(188, 37);
            this.tB_dimension.Name = "tB_dimension";
            this.tB_dimension.Size = new System.Drawing.Size(135, 20);
            this.tB_dimension.TabIndex = 31;
            // 
            // tb_TimeAsync
            // 
            this.tb_TimeAsync.Location = new System.Drawing.Point(144, 223);
            this.tb_TimeAsync.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TimeAsync.Name = "tb_TimeAsync";
            this.tb_TimeAsync.ReadOnly = true;
            this.tb_TimeAsync.Size = new System.Drawing.Size(168, 20);
            this.tb_TimeAsync.TabIndex = 28;
            // 
            // tB_repeat
            // 
            this.tB_repeat.Location = new System.Drawing.Point(187, 89);
            this.tB_repeat.Name = "tB_repeat";
            this.tB_repeat.Size = new System.Drawing.Size(135, 20);
            this.tB_repeat.TabIndex = 36;
            // 
            // lb_Xn_opt_Sync
            // 
            this.lb_Xn_opt_Sync.FormattingEnabled = true;
            this.lb_Xn_opt_Sync.Location = new System.Drawing.Point(558, 336);
            this.lb_Xn_opt_Sync.Name = "lb_Xn_opt_Sync";
            this.lb_Xn_opt_Sync.Size = new System.Drawing.Size(168, 108);
            this.lb_Xn_opt_Sync.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "X(n) opt Async";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sync";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "X(n) opt Sync";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Async";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Количество повторений вызовов:";
            // 
            // lb_Xn_opt_Async
            // 
            this.lb_Xn_opt_Async.FormattingEnabled = true;
            this.lb_Xn_opt_Async.Location = new System.Drawing.Point(144, 336);
            this.lb_Xn_opt_Async.Name = "lb_Xn_opt_Async";
            this.lb_Xn_opt_Async.Size = new System.Drawing.Size(168, 108);
            this.lb_Xn_opt_Async.TabIndex = 32;
            // 
            // cb_func
            // 
            this.cb_func.FormattingEnabled = true;
            this.cb_func.Location = new System.Drawing.Point(188, 7);
            this.cb_func.Name = "cb_func";
            this.cb_func.Size = new System.Drawing.Size(316, 21);
            this.cb_func.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Количество испытаний:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Выбор функции:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Размерность:";
            // 
            // btn_MonteCarlo
            // 
            this.btn_MonteCarlo.Location = new System.Drawing.Point(239, 136);
            this.btn_MonteCarlo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MonteCarlo.Name = "btn_MonteCarlo";
            this.btn_MonteCarlo.Size = new System.Drawing.Size(391, 61);
            this.btn_MonteCarlo.TabIndex = 15;
            this.btn_MonteCarlo.Text = "Параллельный метод Монте-Карло ";
            this.btn_MonteCarlo.UseVisualStyleBackColor = true;
            this.btn_MonteCarlo.Click += new System.EventHandler(this.btn_MonteCarlo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "F opt";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 535);
            this.tabControl1.TabIndex = 41;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(6, 19);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(126, 17);
            this.rb_1.TabIndex = 54;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Метод Монте-Карло";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_1);
            this.groupBox1.Controls.Add(this.rb_sep);
            this.groupBox1.Location = new System.Drawing.Point(552, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 68);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода оптимизации:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 539);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(642, 559);
            this.Name = "Form1";
            this.Text = "Программный комплекс для решения задач глобальной оптимизации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_Fopt_Async;
        private System.Windows.Forms.TextBox tB_iter;
        private System.Windows.Forms.TextBox tb_TimeSync;
        private System.Windows.Forms.TextBox tb_Fopt_Sync;
        private System.Windows.Forms.TextBox tB_dimension;
        private System.Windows.Forms.TextBox tb_TimeAsync;
        private System.Windows.Forms.TextBox tB_repeat;
        private System.Windows.Forms.ListBox lb_Xn_opt_Sync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lb_Xn_opt_Async;
        private System.Windows.Forms.ComboBox cb_func;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_MonteCarlo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button CopyLocalXoptAync;
        private System.Windows.Forms.ListBox lb_BFGSXopt;
        private System.Windows.Forms.Button CopyXoptSync;
        private System.Windows.Forms.Button CopyXoptAsync;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_BFGSFopt_Async;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox CheckL;
        private System.Windows.Forms.RadioButton rb_sep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_1;
    }
}

