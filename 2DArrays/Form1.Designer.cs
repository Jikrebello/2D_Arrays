
namespace _2DArrays
{
    partial class Form1
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnLoadTable = new System.Windows.Forms.Button();
            this.BtnChangeFranksSales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAdd10ToAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(10, 12);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDisplay.Size = new System.Drawing.Size(447, 181);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnLoadTable
            // 
            this.BtnLoadTable.Location = new System.Drawing.Point(10, 242);
            this.BtnLoadTable.Name = "BtnLoadTable";
            this.BtnLoadTable.Size = new System.Drawing.Size(145, 46);
            this.BtnLoadTable.TabIndex = 0;
            this.BtnLoadTable.Text = "View Data";
            this.BtnLoadTable.UseVisualStyleBackColor = true;
            this.BtnLoadTable.Click += new System.EventHandler(this.BtnLoadTable_Click);
            // 
            // BtnChangeFranksSales
            // 
            this.BtnChangeFranksSales.Location = new System.Drawing.Point(10, 294);
            this.BtnChangeFranksSales.Name = "BtnChangeFranksSales";
            this.BtnChangeFranksSales.Size = new System.Drawing.Size(145, 46);
            this.BtnChangeFranksSales.TabIndex = 2;
            this.BtnChangeFranksSales.Text = "Change Franks Sales";
            this.BtnChangeFranksSales.UseVisualStyleBackColor = true;
            this.BtnChangeFranksSales.Click += new System.EventHandler(this.BtnChangeFranksSales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy Lucys sales to Karens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnAdd10ToAll
            // 
            this.BtnAdd10ToAll.Location = new System.Drawing.Point(161, 242);
            this.BtnAdd10ToAll.Name = "BtnAdd10ToAll";
            this.BtnAdd10ToAll.Size = new System.Drawing.Size(145, 46);
            this.BtnAdd10ToAll.TabIndex = 4;
            this.BtnAdd10ToAll.Text = "Add 10 to all";
            this.BtnAdd10ToAll.UseVisualStyleBackColor = true;
            this.BtnAdd10ToAll.Click += new System.EventHandler(this.BtnAdd10ToAll_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sales less than 1000";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Highest sales amount of the week";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Weekly Total Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(312, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 46);
            this.button5.TabIndex = 8;
            this.button5.Text = "Highest Weekly Sales Person";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(312, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 46);
            this.button6.TabIndex = 9;
            this.button6.Text = "Weekly Payout From Commission";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(314, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 27);
            this.button7.TabIndex = 10;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 400);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnAdd10ToAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnChangeFranksSales);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnLoadTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnLoadTable;
        private System.Windows.Forms.Button BtnChangeFranksSales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAdd10ToAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

