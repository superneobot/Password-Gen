
namespace PasswordGen
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.result_gen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gen_range_bar = new System.Windows.Forms.TrackBar();
            this.gen_range = new System.Windows.Forms.Label();
            this.gen_type = new System.Windows.Forms.CheckedListBox();
            this.digits_only = new System.Windows.Forms.CheckBox();
            this.lowletters_only = new System.Windows.Forms.CheckBox();
            this.upletters_only = new System.Windows.Forms.CheckBox();
            this.digitsandletters_only = new System.Windows.Forms.CheckBox();
            this.digitsletterssymbols = new System.Windows.Forms.CheckBox();
            this.pwd_list = new System.Windows.Forms.ListBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gen_range_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // result_gen
            // 
            this.result_gen.Location = new System.Drawing.Point(12, 12);
            this.result_gen.Name = "result_gen";
            this.result_gen.ReadOnly = true;
            this.result_gen.Size = new System.Drawing.Size(220, 20);
            this.result_gen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gen_range_bar
            // 
            this.gen_range_bar.Location = new System.Drawing.Point(12, 38);
            this.gen_range_bar.Maximum = 20;
            this.gen_range_bar.Minimum = 1;
            this.gen_range_bar.Name = "gen_range_bar";
            this.gen_range_bar.Size = new System.Drawing.Size(179, 45);
            this.gen_range_bar.TabIndex = 2;
            this.gen_range_bar.Value = 1;
            this.gen_range_bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // gen_range
            // 
            this.gen_range.AutoSize = true;
            this.gen_range.Location = new System.Drawing.Point(197, 43);
            this.gen_range.Name = "gen_range";
            this.gen_range.Size = new System.Drawing.Size(13, 13);
            this.gen_range.TabIndex = 3;
            this.gen_range.Text = "1";
            // 
            // gen_type
            // 
            this.gen_type.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gen_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gen_type.CheckOnClick = true;
            this.gen_type.FormattingEnabled = true;
            this.gen_type.Items.AddRange(new object[] {
            "Числа",
            "Буквы (нижний регистр)",
            "Буквы (верхний регистр)",
            "Числа и буквы",
            "Числа, буквы и символы"});
            this.gen_type.Location = new System.Drawing.Point(517, 12);
            this.gen_type.Name = "gen_type";
            this.gen_type.Size = new System.Drawing.Size(159, 75);
            this.gen_type.TabIndex = 8;
            this.gen_type.ThreeDCheckBoxes = true;
            this.gen_type.UseTabStops = false;
            // 
            // digits_only
            // 
            this.digits_only.AutoSize = true;
            this.digits_only.Location = new System.Drawing.Point(238, 12);
            this.digits_only.Name = "digits_only";
            this.digits_only.Size = new System.Drawing.Size(58, 17);
            this.digits_only.TabIndex = 9;
            this.digits_only.Text = "Числа";
            this.digits_only.UseVisualStyleBackColor = true;
            this.digits_only.Click += new System.EventHandler(this.digits_only_Click);
            // 
            // lowletters_only
            // 
            this.lowletters_only.AutoSize = true;
            this.lowletters_only.Location = new System.Drawing.Point(238, 35);
            this.lowletters_only.Name = "lowletters_only";
            this.lowletters_only.Size = new System.Drawing.Size(148, 17);
            this.lowletters_only.TabIndex = 10;
            this.lowletters_only.Text = "Буквы (нижний регистр)";
            this.lowletters_only.UseVisualStyleBackColor = true;
            this.lowletters_only.Click += new System.EventHandler(this.lowletters_only_Click);
            // 
            // upletters_only
            // 
            this.upletters_only.AutoSize = true;
            this.upletters_only.Location = new System.Drawing.Point(238, 58);
            this.upletters_only.Name = "upletters_only";
            this.upletters_only.Size = new System.Drawing.Size(151, 17);
            this.upletters_only.TabIndex = 11;
            this.upletters_only.Text = "Буквы (верхний регистр)";
            this.upletters_only.UseVisualStyleBackColor = true;
            this.upletters_only.Click += new System.EventHandler(this.upletters_only_Click);
            // 
            // digitsandletters_only
            // 
            this.digitsandletters_only.AutoSize = true;
            this.digitsandletters_only.Location = new System.Drawing.Point(238, 81);
            this.digitsandletters_only.Name = "digitsandletters_only";
            this.digitsandletters_only.Size = new System.Drawing.Size(122, 17);
            this.digitsandletters_only.TabIndex = 12;
            this.digitsandletters_only.Text = "Числа и буквы (нр)";
            this.digitsandletters_only.UseVisualStyleBackColor = true;
            this.digitsandletters_only.Click += new System.EventHandler(this.digitsandletters_only_Click);
            // 
            // digitsletterssymbols
            // 
            this.digitsletterssymbols.AutoSize = true;
            this.digitsletterssymbols.Location = new System.Drawing.Point(238, 104);
            this.digitsletterssymbols.Name = "digitsletterssymbols";
            this.digitsletterssymbols.Size = new System.Drawing.Size(177, 17);
            this.digitsletterssymbols.TabIndex = 13;
            this.digitsletterssymbols.Text = "Числа, буквы(все) и символы";
            this.digitsletterssymbols.UseVisualStyleBackColor = true;
            this.digitsletterssymbols.Click += new System.EventHandler(this.digitsletterssymbols_Click);
            // 
            // pwd_list
            // 
            this.pwd_list.FormattingEnabled = true;
            this.pwd_list.Location = new System.Drawing.Point(12, 68);
            this.pwd_list.Name = "pwd_list";
            this.pwd_list.Size = new System.Drawing.Size(220, 56);
            this.pwd_list.TabIndex = 14;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(157, 130);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 15;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 130);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 16;
            this.clear_btn.Text = "Очистить";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 161);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.pwd_list);
            this.Controls.Add(this.digitsletterssymbols);
            this.Controls.Add(this.digitsandletters_only);
            this.Controls.Add(this.upletters_only);
            this.Controls.Add(this.lowletters_only);
            this.Controls.Add(this.digits_only);
            this.Controls.Add(this.gen_type);
            this.Controls.Add(this.gen_range);
            this.Controls.Add(this.gen_range_bar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGen";
            ((System.ComponentModel.ISupportInitialize)(this.gen_range_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result_gen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar gen_range_bar;
        private System.Windows.Forms.Label gen_range;
        private System.Windows.Forms.CheckedListBox gen_type;
        private System.Windows.Forms.CheckBox digits_only;
        private System.Windows.Forms.CheckBox lowletters_only;
        private System.Windows.Forms.CheckBox upletters_only;
        private System.Windows.Forms.CheckBox digitsandletters_only;
        private System.Windows.Forms.CheckBox digitsletterssymbols;
        private System.Windows.Forms.ListBox pwd_list;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

