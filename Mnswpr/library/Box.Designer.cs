﻿namespace Mnswpr.library
{
    partial class Box
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box));
            this.pctFlag = new System.Windows.Forms.PictureBox();
            this.lblMines = new System.Windows.Forms.Label();
            this.btnBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFlag
            // 
            this.pctFlag.Image = ((System.Drawing.Image)(resources.GetObject("pctFlag.Image")));
            this.pctFlag.Location = new System.Drawing.Point(0, 0);
            this.pctFlag.Name = "pctFlag";
            this.pctFlag.Size = new System.Drawing.Size(20, 20);
            this.pctFlag.TabIndex = 0;
            this.pctFlag.TabStop = false;
            this.pctFlag.Visible = false;
            // 
            // lblMines
            // 
            this.lblMines.Location = new System.Drawing.Point(0, 0);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(20, 20);
            this.lblMines.TabIndex = 1;
            this.lblMines.Visible = false;
            // 
            // btnBox
            // 
            this.btnBox.BackColor = System.Drawing.SystemColors.Control;
            this.btnBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBox.Location = new System.Drawing.Point(0, 0);
            this.btnBox.Margin = new System.Windows.Forms.Padding(0);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(20, 20);
            this.btnBox.TabIndex = 2;
            this.btnBox.UseVisualStyleBackColor = false;
            this.btnBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBox_MouseDown);
            this.btnBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBox_MouseUp);
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.pctFlag);
            this.Controls.Add(this.lblMines);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Box";
            this.Size = new System.Drawing.Size(20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pctFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFlag;
        private System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.Button btnBox;
    }
}
