namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtB = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.BtnClearE = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtB
            // 
            this.TxtB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB.Location = new System.Drawing.Point(11, 12);
            this.TxtB.Name = "TxtB";
            this.TxtB.ReadOnly = true;
            this.TxtB.Size = new System.Drawing.Size(274, 32);
            this.TxtB.TabIndex = 0;
            this.TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn1
            // 
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(11, 162);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(50, 50);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn3
            // 
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(123, 162);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(50, 50);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn2
            // 
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(67, 162);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(50, 50);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn4
            // 
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(11, 106);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(50, 50);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn5
            // 
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(67, 106);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(50, 50);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn6
            // 
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(123, 106);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(50, 50);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn0
            // 
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(11, 218);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(50, 50);
            this.Btn0.TabIndex = 8;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn9
            // 
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(123, 50);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(50, 50);
            this.Btn9.TabIndex = 9;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn7
            // 
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(11, 50);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(50, 50);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.NumberClick);
            // 
            // Btn8
            // 
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(67, 50);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(50, 50);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.NumberClick);
            // 
            // BtnSub
            // 
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(179, 162);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(50, 50);
            this.BtnSub.TabIndex = 12;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.OperandClick);
            // 
            // BtnMul
            // 
            this.BtnMul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnMul.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.Location = new System.Drawing.Point(179, 106);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(50, 50);
            this.BtnMul.TabIndex = 13;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.OperandClick);
            // 
            // BtnDiv
            // 
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnDiv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(179, 50);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(50, 50);
            this.BtnDiv.TabIndex = 14;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.OperandClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(179, 218);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(50, 50);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.OperandClick);
            // 
            // btnSolve
            // 
            this.btnSolve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSolve.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(67, 218);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(106, 50);
            this.btnSolve.TabIndex = 16;
            this.btnSolve.Text = "=";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // BtnClearE
            // 
            this.BtnClearE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClearE.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearE.Location = new System.Drawing.Point(235, 162);
            this.BtnClearE.Name = "BtnClearE";
            this.BtnClearE.Size = new System.Drawing.Size(50, 106);
            this.BtnClearE.TabIndex = 17;
            this.BtnClearE.Text = "CE";
            this.BtnClearE.UseVisualStyleBackColor = true;
            this.BtnClearE.Click += new System.EventHandler(this.BtnClearE_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(235, 50);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(50, 106);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 277);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnClearE);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TxtB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button BtnClearE;
        private System.Windows.Forms.Button BtnClear;
    }
}

