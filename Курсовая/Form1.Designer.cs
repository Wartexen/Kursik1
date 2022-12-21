
namespace Курсовая
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbCntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tickInfo = new System.Windows.Forms.Label();
            this.tbTick = new System.Windows.Forms.TrackBar();
            this.lbParticles = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.tbLife = new System.Windows.Forms.TrackBar();
            this.lbDir = new System.Windows.Forms.Label();
            this.lbSpred = new System.Windows.Forms.Label();
            this.lbLife = new System.Windows.Forms.Label();
            this.dirInfo = new System.Windows.Forms.Label();
            this.spreadInfo = new System.Windows.Forms.Label();
            this.lifeInfo = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.speedInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.tbCntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(979, 560);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tabPage1);
            this.tbCntrl.Controls.Add(this.tabPage2);
            this.tbCntrl.Location = new System.Drawing.Point(1038, 112);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(180, 80);
            this.tbCntrl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(172, 54);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Цвет";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Красный",
            "Синий",
            "Желтый",
            "Фиолетовый",
            "Зеленый"});
            this.comboBox1.Location = new System.Drawing.Point(21, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(172, 54);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Счетчик";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tickInfo
            // 
            this.tickInfo.AutoSize = true;
            this.tickInfo.Location = new System.Drawing.Point(1108, 54);
            this.tickInfo.Name = "tickInfo";
            this.tickInfo.Size = new System.Drawing.Size(0, 13);
            this.tickInfo.TabIndex = 3;
            // 
            // tbTick
            // 
            this.tbTick.Location = new System.Drawing.Point(1032, 70);
            this.tbTick.Maximum = 100;
            this.tbTick.Minimum = 10;
            this.tbTick.Name = "tbTick";
            this.tbTick.Size = new System.Drawing.Size(180, 45);
            this.tbTick.TabIndex = 1;
            this.tbTick.Value = 10;
            this.tbTick.Scroll += new System.EventHandler(this.tbTick_Scroll);
            // 
            // lbParticles
            // 
            this.lbParticles.AutoSize = true;
            this.lbParticles.Location = new System.Drawing.Point(1037, 54);
            this.lbParticles.Name = "lbParticles";
            this.lbParticles.Size = new System.Drawing.Size(73, 13);
            this.lbParticles.TabIndex = 2;
            this.lbParticles.Text = "Частиц в тик";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1032, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Задание 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(1032, 134);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(180, 45);
            this.tbDirection.TabIndex = 7;
            this.tbDirection.Scroll += new System.EventHandler(this.tbSpeed1_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1129, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Задание 5-6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(1032, 198);
            this.tbSpreading.Maximum = 100;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(180, 45);
            this.tbSpreading.TabIndex = 9;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // tbLife
            // 
            this.tbLife.Location = new System.Drawing.Point(1032, 258);
            this.tbLife.Maximum = 100;
            this.tbLife.Minimum = 20;
            this.tbLife.Name = "tbLife";
            this.tbLife.Size = new System.Drawing.Size(180, 45);
            this.tbLife.TabIndex = 10;
            this.tbLife.Value = 50;
            this.tbLife.Scroll += new System.EventHandler(this.tbLife_Scroll);
            // 
            // lbDir
            // 
            this.lbDir.AutoSize = true;
            this.lbDir.Location = new System.Drawing.Point(1035, 118);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(75, 13);
            this.lbDir.TabIndex = 12;
            this.lbDir.Text = "Направление";
            // 
            // lbSpred
            // 
            this.lbSpred.AutoSize = true;
            this.lbSpred.Location = new System.Drawing.Point(1035, 182);
            this.lbSpred.Name = "lbSpred";
            this.lbSpred.Size = new System.Drawing.Size(50, 13);
            this.lbSpred.TabIndex = 13;
            this.lbSpred.Text = "Разброс";
            // 
            // lbLife
            // 
            this.lbLife.AutoSize = true;
            this.lbLife.Location = new System.Drawing.Point(1039, 242);
            this.lbLife.Name = "lbLife";
            this.lbLife.Size = new System.Drawing.Size(42, 13);
            this.lbLife.TabIndex = 14;
            this.lbLife.Text = "Жизнь";
            // 
            // dirInfo
            // 
            this.dirInfo.AutoSize = true;
            this.dirInfo.Location = new System.Drawing.Point(1116, 118);
            this.dirInfo.Name = "dirInfo";
            this.dirInfo.Size = new System.Drawing.Size(0, 13);
            this.dirInfo.TabIndex = 15;
            // 
            // spreadInfo
            // 
            this.spreadInfo.AutoSize = true;
            this.spreadInfo.Location = new System.Drawing.Point(1091, 182);
            this.spreadInfo.Name = "spreadInfo";
            this.spreadInfo.Size = new System.Drawing.Size(0, 13);
            this.spreadInfo.TabIndex = 16;
            // 
            // lifeInfo
            // 
            this.lifeInfo.AutoSize = true;
            this.lifeInfo.Location = new System.Drawing.Point(1087, 242);
            this.lifeInfo.Name = "lifeInfo";
            this.lifeInfo.Size = new System.Drawing.Size(0, 13);
            this.lifeInfo.TabIndex = 17;
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(1034, 319);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Minimum = 10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(180, 45);
            this.tbSpeed.TabIndex = 18;
            this.tbSpeed.Value = 10;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(1039, 303);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(55, 13);
            this.lbSpeed.TabIndex = 19;
            this.lbSpeed.Text = "Скорость";
            // 
            // speedInfo
            // 
            this.speedInfo.AutoSize = true;
            this.speedInfo.Location = new System.Drawing.Point(1100, 306);
            this.speedInfo.Name = "speedInfo";
            this.speedInfo.Size = new System.Drawing.Size(0, 13);
            this.speedInfo.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 566);
            this.Controls.Add(this.speedInfo);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lifeInfo);
            this.Controls.Add(this.spreadInfo);
            this.Controls.Add(this.dirInfo);
            this.Controls.Add(this.lbLife);
            this.Controls.Add(this.lbSpred);
            this.Controls.Add(this.lbDir);
            this.Controls.Add(this.tbLife);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tickInfo);
            this.Controls.Add(this.tbCntrl);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.tbTick);
            this.Controls.Add(this.lbParticles);
            this.Name = "Form1";
            this.Text = "Система Частиц";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.tbCntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tbCntrl;
        private System.Windows.Forms.TrackBar tbTick;
        private System.Windows.Forms.Label lbParticles;
        private System.Windows.Forms.Label tickInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.TrackBar tbLife;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.Label lbSpred;
        private System.Windows.Forms.Label lbLife;
        private System.Windows.Forms.Label dirInfo;
        private System.Windows.Forms.Label spreadInfo;
        private System.Windows.Forms.Label lifeInfo;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label speedInfo;
    }
}

