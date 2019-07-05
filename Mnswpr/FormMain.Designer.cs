namespace Mnswpr
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlArena = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rdoHard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoEasy = new System.Windows.Forms.RadioButton();
            this.lblMineCount = new System.Windows.Forms.Label();
            this.gbLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArena
            // 
            this.pnlArena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlArena.Location = new System.Drawing.Point(12, 50);
            this.pnlArena.Name = "pnlArena";
            this.pnlArena.Size = new System.Drawing.Size(200, 200);
            this.pnlArena.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "New game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbLevel
            // 
            this.gbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbLevel.Controls.Add(this.rdoHard);
            this.gbLevel.Controls.Add(this.rdoNormal);
            this.gbLevel.Controls.Add(this.rdoEasy);
            this.gbLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevel.Location = new System.Drawing.Point(234, 50);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(100, 100);
            this.gbLevel.TabIndex = 2;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            // 
            // rdoHard
            // 
            this.rdoHard.AutoSize = true;
            this.rdoHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHard.Location = new System.Drawing.Point(11, 70);
            this.rdoHard.Name = "rdoHard";
            this.rdoHard.Size = new System.Drawing.Size(55, 20);
            this.rdoHard.TabIndex = 0;
            this.rdoHard.TabStop = true;
            this.rdoHard.Text = "Hard";
            this.rdoHard.UseVisualStyleBackColor = true;
            this.rdoHard.Click += new System.EventHandler(this.rdoLevel_Click);
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormal.Location = new System.Drawing.Point(11, 47);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(69, 20);
            this.rdoNormal.TabIndex = 0;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.Click += new System.EventHandler(this.rdoLevel_Click);
            // 
            // rdoEasy
            // 
            this.rdoEasy.AutoSize = true;
            this.rdoEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEasy.Location = new System.Drawing.Point(11, 24);
            this.rdoEasy.Name = "rdoEasy";
            this.rdoEasy.Size = new System.Drawing.Size(56, 20);
            this.rdoEasy.TabIndex = 0;
            this.rdoEasy.TabStop = true;
            this.rdoEasy.Text = "Easy";
            this.rdoEasy.UseVisualStyleBackColor = true;
            this.rdoEasy.Click += new System.EventHandler(this.rdoLevel_Click);
            // 
            // lblMineCount
            // 
            this.lblMineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMineCount.BackColor = System.Drawing.Color.Black;
            this.lblMineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMineCount.ForeColor = System.Drawing.Color.White;
            this.lblMineCount.Location = new System.Drawing.Point(234, 165);
            this.lblMineCount.Name = "lblMineCount";
            this.lblMineCount.Size = new System.Drawing.Size(100, 23);
            this.lblMineCount.TabIndex = 3;
            this.lblMineCount.Text = "100";
            this.lblMineCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.lblMineCount);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Minesweeper by dhmm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArena;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.RadioButton rdoHard;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoEasy;
        private System.Windows.Forms.Label lblMineCount;
    }
}

