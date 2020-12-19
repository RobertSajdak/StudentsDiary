
using System;

namespace StudentsDiary
{
    partial class AddEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEnglishLang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPolishLang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhisics = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboxIdClass = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(121, 12);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(244, 22);
            this.tbId.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 12);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 17);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ld:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(121, 40);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(244, 22);
            this.tbFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matematyka:";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(121, 96);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(244, 22);
            this.tbMath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(121, 68);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(244, 22);
            this.tbLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Język angielski:";
            // 
            // tbEnglishLang
            // 
            this.tbEnglishLang.Location = new System.Drawing.Point(121, 208);
            this.tbEnglishLang.Name = "tbEnglishLang";
            this.tbEnglishLang.Size = new System.Drawing.Size(244, 22);
            this.tbEnglishLang.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Język polski:";
            // 
            // tbPolishLang
            // 
            this.tbPolishLang.Location = new System.Drawing.Point(121, 180);
            this.tbPolishLang.Name = "tbPolishLang";
            this.tbPolishLang.Size = new System.Drawing.Size(244, 22);
            this.tbPolishLang.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fizyka:";
            // 
            // tbPhisics
            // 
            this.tbPhisics.Location = new System.Drawing.Point(121, 152);
            this.tbPhisics.Name = "tbPhisics";
            this.tbPhisics.Size = new System.Drawing.Size(244, 22);
            this.tbPhisics.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Technologia:";
            // 
            // tbTechnology
            // 
            this.tbTechnology.Location = new System.Drawing.Point(121, 124);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(244, 22);
            this.tbTechnology.TabIndex = 8;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(121, 236);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(244, 26);
            this.rtbComments.TabIndex = 16;
            this.rtbComments.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Uwagi:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(121, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 30);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(276, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(89, 30);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleDescription = "";
            this.checkBox1.AccessibleName = "";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(217, 270);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Zajęcia dodatkowe";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboxIdClass
            // 
            this.cboxIdClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxIdClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxIdClass.DropDownHeight = 100;
            this.cboxIdClass.FormattingEnabled = true;
            this.cboxIdClass.IntegralHeight = false;
            this.cboxIdClass.Items.AddRange(new object[] {
            "I-A",
            "I-B",
            "I-C",
            "II-A",
            "II-B",
            "III-A",
            "IV-A"});
            this.cboxIdClass.Location = new System.Drawing.Point(121, 268);
            this.cboxIdClass.Name = "cboxIdClass";
            this.cboxIdClass.Size = new System.Drawing.Size(81, 24);
            this.cboxIdClass.Sorted = true;
            this.cboxIdClass.TabIndex = 21;
            this.cboxIdClass.SelectedIndexChanged += new System.EventHandler(this.cboxIdClass_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Klasa ucznia:";
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 382);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboxIdClass);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEnglishLang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPolishLang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPhisics);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTechnology);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.MaximumSize = new System.Drawing.Size(401, 429);
            this.MinimumSize = new System.Drawing.Size(401, 429);
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie ucznia";
            this.Load += new System.EventHandler(this.AddEditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEnglishLang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPolishLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPhisics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTechnology;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cboxIdClass;
        private System.Windows.Forms.Label label9;
    }
}