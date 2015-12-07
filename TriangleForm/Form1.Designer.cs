namespace TriangleForm
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
            this.cbRightAngle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngleA = new System.Windows.Forms.TextBox();
            this.txtAngleB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnDoStuff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRightAngle
            // 
            this.cbRightAngle.AutoSize = true;
            this.cbRightAngle.Location = new System.Drawing.Point(10, 12);
            this.cbRightAngle.Name = "cbRightAngle";
            this.cbRightAngle.Size = new System.Drawing.Size(93, 17);
            this.cbRightAngle.TabIndex = 0;
            this.cbRightAngle.Text = "Right Angled?";
            this.cbRightAngle.UseVisualStyleBackColor = true;
            this.cbRightAngle.CheckedChanged += new System.EventHandler(this.cbRightAngle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Side A";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(64, 35);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(53, 20);
            this.txtSideA.TabIndex = 2;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(64, 61);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(53, 20);
            this.txtSideB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Side B";
            // 
            // txtAngleA
            // 
            this.txtAngleA.Location = new System.Drawing.Point(64, 105);
            this.txtAngleA.Name = "txtAngleA";
            this.txtAngleA.Size = new System.Drawing.Size(53, 20);
            this.txtAngleA.TabIndex = 6;
            // 
            // txtAngleB
            // 
            this.txtAngleB.Location = new System.Drawing.Point(64, 131);
            this.txtAngleB.Name = "txtAngleB";
            this.txtAngleB.Size = new System.Drawing.Size(53, 20);
            this.txtAngleB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Angle A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Angle B";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(10, 224);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(147, 89);
            this.txtResults.TabIndex = 10;
            // 
            // btnDoStuff
            // 
            this.btnDoStuff.Location = new System.Drawing.Point(12, 172);
            this.btnDoStuff.Name = "btnDoStuff";
            this.btnDoStuff.Size = new System.Drawing.Size(145, 23);
            this.btnDoStuff.TabIndex = 11;
            this.btnDoStuff.Text = "Do Stuff";
            this.btnDoStuff.UseVisualStyleBackColor = true;
            this.btnDoStuff.Click += new System.EventHandler(this.btnDoStuff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 316);
            this.Controls.Add(this.btnDoStuff);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAngleB);
            this.Controls.Add(this.txtAngleA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRightAngle);
            this.Name = "Form1";
            this.Text = "Triangles...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRightAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngleA;
        private System.Windows.Forms.TextBox txtAngleB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnDoStuff;
    }
}

