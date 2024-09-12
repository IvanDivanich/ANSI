namespace ANSI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.randomSymbol = new System.Windows.Forms.CheckBox();
            this.randomColor = new System.Windows.Forms.CheckBox();
            this.fontSizeTB = new System.Windows.Forms.TrackBar();
            this.symbolCB = new System.Windows.Forms.ComboBox();
            this.hTB = new System.Windows.Forms.TextBox();
            this.wTb = new System.Windows.Forms.TextBox();
            this.foreColorBtn = new System.Windows.Forms.Button();
            this.brushBGColorBtn = new System.Windows.Forms.Button();
            this.gridBGBtn = new System.Windows.Forms.Button();
            this.fontSizeLB = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.CteateBtn = new System.Windows.Forms.Button();
            this.cont = new System.Windows.Forms.Panel();
            this.openBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.widthLB = new System.Windows.Forms.Label();
            this.widthTB = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.heightLB = new System.Windows.Forms.Label();
            this.heightTB = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.randomSymbol);
            this.panel1.Controls.Add(this.randomColor);
            this.panel1.Controls.Add(this.heightTB);
            this.panel1.Controls.Add(this.widthTB);
            this.panel1.Controls.Add(this.fontSizeTB);
            this.panel1.Controls.Add(this.symbolCB);
            this.panel1.Controls.Add(this.hTB);
            this.panel1.Controls.Add(this.wTb);
            this.panel1.Controls.Add(this.foreColorBtn);
            this.panel1.Controls.Add(this.heightLB);
            this.panel1.Controls.Add(this.brushBGColorBtn);
            this.panel1.Controls.Add(this.widthLB);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.gridBGBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.fontSizeLB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.openBtn);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.ClearAllBtn);
            this.panel1.Controls.Add(this.CteateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 758);
            this.panel1.TabIndex = 0;
            // 
            // randomSymbol
            // 
            this.randomSymbol.AutoSize = true;
            this.randomSymbol.Location = new System.Drawing.Point(12, 607);
            this.randomSymbol.Name = "randomSymbol";
            this.randomSymbol.Size = new System.Drawing.Size(122, 17);
            this.randomSymbol.TabIndex = 7;
            this.randomSymbol.Text = "Случайный символ";
            this.randomSymbol.UseVisualStyleBackColor = true;
            // 
            // randomColor
            // 
            this.randomColor.AutoSize = true;
            this.randomColor.Location = new System.Drawing.Point(12, 584);
            this.randomColor.Name = "randomColor";
            this.randomColor.Size = new System.Drawing.Size(154, 17);
            this.randomColor.TabIndex = 7;
            this.randomColor.Text = "Случайный цвет символа";
            this.randomColor.UseVisualStyleBackColor = true;
            // 
            // fontSizeTB
            // 
            this.fontSizeTB.LargeChange = 1;
            this.fontSizeTB.Location = new System.Drawing.Point(12, 389);
            this.fontSizeTB.Maximum = 25;
            this.fontSizeTB.Minimum = 1;
            this.fontSizeTB.Name = "fontSizeTB";
            this.fontSizeTB.Size = new System.Drawing.Size(177, 45);
            this.fontSizeTB.TabIndex = 6;
            this.fontSizeTB.Value = 15;
            this.fontSizeTB.Scroll += new System.EventHandler(this.fontSizeTB_Scroll);
            // 
            // symbolCB
            // 
            this.symbolCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbolCB.FormattingEnabled = true;
            this.symbolCB.Location = new System.Drawing.Point(12, 337);
            this.symbolCB.Name = "symbolCB";
            this.symbolCB.Size = new System.Drawing.Size(177, 23);
            this.symbolCB.TabIndex = 5;
            this.symbolCB.SelectedIndexChanged += new System.EventHandler(this.symbolCB_SelectedIndexChanged);
            // 
            // hTB
            // 
            this.hTB.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hTB.Location = new System.Drawing.Point(64, 39);
            this.hTB.Name = "hTB";
            this.hTB.Size = new System.Drawing.Size(125, 22);
            this.hTB.TabIndex = 4;
            // 
            // wTb
            // 
            this.wTb.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wTb.Location = new System.Drawing.Point(64, 12);
            this.wTb.Name = "wTb";
            this.wTb.Size = new System.Drawing.Size(125, 22);
            this.wTb.TabIndex = 4;
            // 
            // foreColorBtn
            // 
            this.foreColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foreColorBtn.Location = new System.Drawing.Point(12, 277);
            this.foreColorBtn.Name = "foreColorBtn";
            this.foreColorBtn.Size = new System.Drawing.Size(177, 23);
            this.foreColorBtn.TabIndex = 3;
            this.foreColorBtn.UseVisualStyleBackColor = true;
            this.foreColorBtn.Click += new System.EventHandler(this.foreColorBtn_Click);
            // 
            // brushBGColorBtn
            // 
            this.brushBGColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushBGColorBtn.Location = new System.Drawing.Point(12, 213);
            this.brushBGColorBtn.Name = "brushBGColorBtn";
            this.brushBGColorBtn.Size = new System.Drawing.Size(177, 23);
            this.brushBGColorBtn.TabIndex = 3;
            this.brushBGColorBtn.UseVisualStyleBackColor = true;
            this.brushBGColorBtn.Click += new System.EventHandler(this.brushBGColorBtn_Click);
            // 
            // gridBGBtn
            // 
            this.gridBGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gridBGBtn.Location = new System.Drawing.Point(12, 157);
            this.gridBGBtn.Name = "gridBGBtn";
            this.gridBGBtn.Size = new System.Drawing.Size(177, 23);
            this.gridBGBtn.TabIndex = 3;
            this.gridBGBtn.UseVisualStyleBackColor = true;
            this.gridBGBtn.Click += new System.EventHandler(this.gridBG_Click);
            // 
            // fontSizeLB
            // 
            this.fontSizeLB.AutoSize = true;
            this.fontSizeLB.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontSizeLB.Location = new System.Drawing.Point(61, 372);
            this.fontSizeLB.Name = "fontSizeLB";
            this.fontSizeLB.Size = new System.Drawing.Size(21, 14);
            this.fontSizeLB.TabIndex = 2;
            this.fontSizeLB.Text = "15";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Шрифт:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Символ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цвет шрифта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет фона кисти";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ширина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цвет фона доски";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(12, 694);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(180, 23);
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(12, 665);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClearAllBtn.FlatAppearance.BorderSize = 0;
            this.ClearAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAllBtn.ForeColor = System.Drawing.Color.White;
            this.ClearAllBtn.Location = new System.Drawing.Point(12, 105);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(180, 23);
            this.ClearAllBtn.TabIndex = 0;
            this.ClearAllBtn.Text = "Очистить всё";
            this.ClearAllBtn.UseVisualStyleBackColor = false;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // CteateBtn
            // 
            this.CteateBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.CteateBtn.FlatAppearance.BorderSize = 0;
            this.CteateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CteateBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CteateBtn.ForeColor = System.Drawing.Color.White;
            this.CteateBtn.Location = new System.Drawing.Point(12, 69);
            this.CteateBtn.Name = "CteateBtn";
            this.CteateBtn.Size = new System.Drawing.Size(180, 23);
            this.CteateBtn.TabIndex = 0;
            this.CteateBtn.Text = "Создать";
            this.CteateBtn.UseVisualStyleBackColor = false;
            this.CteateBtn.Click += new System.EventHandler(this.CteateBtn_Click);
            // 
            // cont
            // 
            this.cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cont.Location = new System.Drawing.Point(203, 0);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(974, 758);
            this.cont.TabIndex = 1;
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.openBtn.FlatAppearance.BorderSize = 0;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBtn.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Location = new System.Drawing.Point(12, 723);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(180, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Открыть";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ширина";
            // 
            // widthLB
            // 
            this.widthLB.AutoSize = true;
            this.widthLB.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLB.Location = new System.Drawing.Point(61, 435);
            this.widthLB.Name = "widthLB";
            this.widthLB.Size = new System.Drawing.Size(21, 14);
            this.widthLB.TabIndex = 2;
            this.widthLB.Text = "15";
            // 
            // widthTB
            // 
            this.widthTB.LargeChange = 1;
            this.widthTB.Location = new System.Drawing.Point(12, 452);
            this.widthTB.Maximum = 30;
            this.widthTB.Minimum = 1;
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(177, 45);
            this.widthTB.TabIndex = 6;
            this.widthTB.Value = 15;
            this.widthTB.Scroll += new System.EventHandler(this.widthTB_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Высота";
            // 
            // heightLB
            // 
            this.heightLB.AutoSize = true;
            this.heightLB.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLB.Location = new System.Drawing.Point(61, 497);
            this.heightLB.Name = "heightLB";
            this.heightLB.Size = new System.Drawing.Size(21, 14);
            this.heightLB.TabIndex = 2;
            this.heightLB.Text = "15";
            // 
            // heightTB
            // 
            this.heightTB.LargeChange = 1;
            this.heightTB.Location = new System.Drawing.Point(12, 514);
            this.heightTB.Maximum = 30;
            this.heightTB.Minimum = 1;
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(177, 45);
            this.heightTB.TabIndex = 6;
            this.heightTB.Value = 15;
            this.heightTB.Scroll += new System.EventHandler(this.heightTB_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 758);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CteateBtn;
        private System.Windows.Forms.Panel cont;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gridBGBtn;
        private System.Windows.Forms.Button foreColorBtn;
        private System.Windows.Forms.Button brushBGColorBtn;
        private System.Windows.Forms.TextBox wTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox symbolCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar fontSizeTB;
        private System.Windows.Forms.Label fontSizeLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.CheckBox randomSymbol;
        private System.Windows.Forms.CheckBox randomColor;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TrackBar widthTB;
        private System.Windows.Forms.Label widthLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar heightTB;
        private System.Windows.Forms.Label heightLB;
        private System.Windows.Forms.Label label9;
    }
}

