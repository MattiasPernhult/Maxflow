namespace FF1
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
            this.comboLeft = new System.Windows.Forms.ComboBox();
            this.comboRight = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnMaximal = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboLeft
            // 
            this.comboLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLeft.FormattingEnabled = true;
            this.comboLeft.Location = new System.Drawing.Point(40, 12);
            this.comboLeft.Name = "comboLeft";
            this.comboLeft.Size = new System.Drawing.Size(55, 21);
            this.comboLeft.TabIndex = 1;
            this.comboLeft.SelectedIndexChanged += new System.EventHandler(this.comboLeft_SelectedIndexChanged);
            // 
            // comboRight
            // 
            this.comboRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRight.FormattingEnabled = true;
            this.comboRight.Location = new System.Drawing.Point(184, 12);
            this.comboRight.Name = "comboRight";
            this.comboRight.Size = new System.Drawing.Size(55, 21);
            this.comboRight.TabIndex = 2;
            this.comboRight.SelectedIndexChanged += new System.EventHandler(this.comboRight_SelectedIndexChanged);
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.Silver;
            this.btnConn.Location = new System.Drawing.Point(291, 28);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 3;
            this.btnConn.Text = "Koppla ihop";
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnMaximal
            // 
            this.btnMaximal.BackColor = System.Drawing.Color.Silver;
            this.btnMaximal.Location = new System.Drawing.Point(291, 85);
            this.btnMaximal.Name = "btnMaximal";
            this.btnMaximal.Size = new System.Drawing.Size(75, 23);
            this.btnMaximal.TabIndex = 4;
            this.btnMaximal.Text = "Maximal";
            this.btnMaximal.UseVisualStyleBackColor = false;
            this.btnMaximal.Click += new System.EventHandler(this.btnMaximal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Silver;
            this.btnRemove.Location = new System.Drawing.Point(291, 57);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 22);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Ta bort koppling";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(291, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Återställ";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 377);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnMaximal);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.comboRight);
            this.Controls.Add(this.comboLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboLeft;
        private System.Windows.Forms.ComboBox comboRight;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnMaximal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
    }
}