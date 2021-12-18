
namespace CaseStudyToonDieltjens
{
    partial class FormTvGuide
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Channel = new System.Windows.Forms.ColumnHeader();
            this.Airtime = new System.Windows.Forms.ColumnHeader();
            this.PlayDays = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 217);
            this.button1.TabIndex = 0;
            this.button1.Text = "TV Guide";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(-3, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 217);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add\r\nTV show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(-3, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 217);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(-3, 628);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 217);
            this.button4.TabIndex = 3;
            this.button4.Text = "My List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(634, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "TV Guide with the best watched TV Shows";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Channel,
            this.Airtime,
            this.PlayDays});
            this.listView1.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(289, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(697, 581);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 250;
            // 
            // Channel
            // 
            this.Channel.Text = "Channel";
            this.Channel.Width = 100;
            // 
            // Airtime
            // 
            this.Airtime.Text = "Airtime";
            this.Airtime.Width = 90;
            // 
            // PlayDays
            // 
            this.PlayDays.Text = "Days on tv";
            this.PlayDays.Width = 250;
            // 
            // FormTvGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1691, 846);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.Name = "FormTvGuide";
            this.Text = "TV Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Channel;
        private System.Windows.Forms.ColumnHeader Airtime;
        private System.Windows.Forms.ColumnHeader PlayDays;
    }
}

