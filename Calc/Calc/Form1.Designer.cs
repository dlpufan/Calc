namespace Calc
{
    partial class Form1
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
            this.Main = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.Panel();
            this.ResultLable = new System.Windows.Forms.Label();
            this.UserChoose = new System.Windows.Forms.Panel();
            this.equals = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.UserInput = new System.Windows.Forms.Panel();
            this.Second = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.Label();
            this.SecondText = new System.Windows.Forms.TextBox();
            this.FirstText = new System.Windows.Forms.TextBox();
            this.Main.SuspendLayout();
            this.Result.SuspendLayout();
            this.UserChoose.SuspendLayout();
            this.UserInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.Result);
            this.Main.Controls.Add(this.UserChoose);
            this.Main.Controls.Add(this.UserInput);
            this.Main.Location = new System.Drawing.Point(42, 31);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(706, 382);
            this.Main.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.ResultLable);
            this.Result.Location = new System.Drawing.Point(33, 153);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(250, 201);
            this.Result.TabIndex = 2;
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLable.Location = new System.Drawing.Point(9, 66);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(102, 52);
            this.ResultLable.TabIndex = 0;
            this.ResultLable.Text = "结果";
            this.ResultLable.Click += new System.EventHandler(this.ResultLable_Click);
            // 
            // UserChoose
            // 
            this.UserChoose.Controls.Add(this.equals);
            this.UserChoose.Controls.Add(this.devide);
            this.UserChoose.Controls.Add(this.multiply);
            this.UserChoose.Controls.Add(this.subtract);
            this.UserChoose.Controls.Add(this.plus);
            this.UserChoose.Location = new System.Drawing.Point(319, 24);
            this.UserChoose.Name = "UserChoose";
            this.UserChoose.Size = new System.Drawing.Size(341, 330);
            this.UserChoose.TabIndex = 1;
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals.Location = new System.Drawing.Point(24, 211);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(294, 85);
            this.equals.TabIndex = 2;
            this.equals.Text = "取余";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // devide
            // 
            this.devide.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.devide.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.devide.Location = new System.Drawing.Point(185, 120);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(134, 66);
            this.devide.TabIndex = 0;
            this.devide.Text = "÷";
            this.devide.UseVisualStyleBackColor = true;
            this.devide.Click += new System.EventHandler(this.button4_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.Location = new System.Drawing.Point(24, 120);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(134, 66);
            this.multiply.TabIndex = 0;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtract.Location = new System.Drawing.Point(185, 26);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(134, 66);
            this.subtract.TabIndex = 1;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.button2_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(24, 26);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(134, 66);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserInput
            // 
            this.UserInput.Controls.Add(this.Second);
            this.UserInput.Controls.Add(this.First);
            this.UserInput.Controls.Add(this.SecondText);
            this.UserInput.Controls.Add(this.FirstText);
            this.UserInput.Location = new System.Drawing.Point(33, 24);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(247, 111);
            this.UserInput.TabIndex = 0;
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Location = new System.Drawing.Point(9, 60);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(69, 20);
            this.Second.TabIndex = 3;
            this.Second.Text = "第二个数";
            this.Second.Click += new System.EventHandler(this.label2_Click);
            // 
            // First
            // 
            this.First.AutoSize = true;
            this.First.Location = new System.Drawing.Point(9, 29);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(69, 20);
            this.First.TabIndex = 2;
            this.First.Text = "第一个数";
            this.First.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecondText
            // 
            this.SecondText.Location = new System.Drawing.Point(84, 60);
            this.SecondText.Name = "SecondText";
            this.SecondText.Size = new System.Drawing.Size(151, 27);
            this.SecondText.TabIndex = 1;
            // 
            // FirstText
            // 
            this.FirstText.Location = new System.Drawing.Point(84, 26);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(151, 27);
            this.FirstText.TabIndex = 0;
            this.FirstText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main);
            this.Name = "Form1";
            this.Text = "YB的计算器";
            this.Main.ResumeLayout(false);
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.UserChoose.ResumeLayout(false);
            this.UserInput.ResumeLayout(false);
            this.UserInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel UserChoose;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Panel UserInput;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label First;
        private System.Windows.Forms.TextBox SecondText;
        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Panel Result;
        private System.Windows.Forms.Label ResultLable;
    }
}

