﻿namespace Notas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblFirstPlace = new System.Windows.Forms.Label();
            this.lblSecondPlace = new System.Windows.Forms.Label();
            this.lblThirdPlace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Image = global::Notas.Properties.Resources.nuevo_usuario;
            this.btnAdd.Location = new System.Drawing.Point(412, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(165, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre del estudiante:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(12, 45);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(112, 19);
            this.lblGrade.TabIndex = 3;
            this.lblGrade.Text = "Nota del 0-100:";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(138, 44);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(181, 20);
            this.txtGrade.TabIndex = 6;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(12, 96);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(77, 19);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Promedio:";
            // 
            // lblFirstPlace
            // 
            this.lblFirstPlace.AutoSize = true;
            this.lblFirstPlace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlace.Location = new System.Drawing.Point(13, 130);
            this.lblFirstPlace.Name = "lblFirstPlace";
            this.lblFirstPlace.Size = new System.Drawing.Size(80, 19);
            this.lblFirstPlace.TabIndex = 8;
            this.lblFirstPlace.Text = "1er Lugar:";
            // 
            // lblSecondPlace
            // 
            this.lblSecondPlace.AutoSize = true;
            this.lblSecondPlace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlace.Location = new System.Drawing.Point(13, 154);
            this.lblSecondPlace.Name = "lblSecondPlace";
            this.lblSecondPlace.Size = new System.Drawing.Size(82, 19);
            this.lblSecondPlace.TabIndex = 9;
            this.lblSecondPlace.Text = "2do Lugar:";
            // 
            // lblThirdPlace
            // 
            this.lblThirdPlace.AutoSize = true;
            this.lblThirdPlace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlace.Location = new System.Drawing.Point(13, 184);
            this.lblThirdPlace.Name = "lblThirdPlace";
            this.lblThirdPlace.Size = new System.Drawing.Size(80, 19);
            this.lblThirdPlace.TabIndex = 10;
            this.lblThirdPlace.Text = "3er Lugar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThirdPlace);
            this.Controls.Add(this.lblSecondPlace);
            this.Controls.Add(this.lblFirstPlace);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFirstPlace;
        private System.Windows.Forms.Label lblSecondPlace;
        private System.Windows.Forms.Label lblThirdPlace;
    }
}

