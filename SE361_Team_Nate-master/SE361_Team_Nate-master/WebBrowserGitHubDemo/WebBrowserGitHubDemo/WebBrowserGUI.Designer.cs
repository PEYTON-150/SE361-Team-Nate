namespace WebBrowserGitHubDemo
{
    partial class WebBrowserGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.wbrDisplay = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.button2 = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
=======
            this.buMax = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
<<<<<<< Updated upstream
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.Size = new System.Drawing.Size(184, 37);
=======
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
>>>>>>> Stashed changes
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter URL:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(132, 41);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
<<<<<<< Updated upstream
            this.txtURL.Location = new System.Drawing.Point(264, 79);
            this.txtURL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(266, 20);
            this.txtURL.Size = new System.Drawing.Size(528, 31);
=======
            this.txtURL.Location = new System.Drawing.Point(132, 41);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(266, 20);
>>>>>>> Stashed changes
            this.txtURL.TabIndex = 1;
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGO.Location = new System.Drawing.Point(404, 35);
            this.btnGO.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
<<<<<<< Updated upstream
            this.btnGO.Location = new System.Drawing.Point(808, 68);
            this.btnGO.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(74, 34);
            this.btnGO.Size = new System.Drawing.Size(149, 65);
=======
            this.btnGO.Location = new System.Drawing.Point(404, 35);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 34);
>>>>>>> Stashed changes
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // wbrDisplay
            // 
            this.wbrDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbrDisplay.Location = new System.Drawing.Point(-2, 75);
            this.wbrDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.wbrDisplay.MinimumSize = new System.Drawing.Size(20, 20);
<<<<<<< Updated upstream
            this.wbrDisplay.Location = new System.Drawing.Point(-5, 144);
            this.wbrDisplay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.wbrDisplay.MinimumSize = new System.Drawing.Size(40, 39);
            this.wbrDisplay.Name = "wbrDisplay";
            this.wbrDisplay.Size = new System.Drawing.Size(718, 360);
            this.wbrDisplay.Size = new System.Drawing.Size(1437, 692);
=======
            this.wbrDisplay.Location = new System.Drawing.Point(-3, 75);
            this.wbrDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrDisplay.Name = "wbrDisplay";
            this.wbrDisplay.Size = new System.Drawing.Size(719, 360);
>>>>>>> Stashed changes
            this.wbrDisplay.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
<<<<<<< Updated upstream
            this.button1.Location = new System.Drawing.Point(1056, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 42);
            this.button1.Size = new System.Drawing.Size(76, 80);
=======
            this.button1.Location = new System.Drawing.Point(528, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
>>>>>>> Stashed changes
            this.button1.TabIndex = 4;
            this.button1.Text = "yerrrrr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Click += new System.EventHandler(this.buMax_Click);
            // 
            // buMax
            // 
            this.buMax.Location = new System.Drawing.Point(30, 386);
            this.buMax.Name = "buMax";
            this.buMax.Size = new System.Drawing.Size(75, 23);
            this.buMax.TabIndex = 5;
            this.buMax.Text = "clear";
            this.buMax.UseVisualStyleBackColor = true;
            this.buMax.Click += new System.EventHandler(this.buMax_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cButton
            // 
            this.cButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton.Image = ((System.Drawing.Image)(resources.GetObject("cButton.Image")));
            this.cButton.Location = new System.Drawing.Point(44, 117);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(207, 133);
            this.cButton.TabIndex = 6;
            this.cButton.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Click += new System.EventHandler(this.buMax_Click);
            // 
            // buMax
            // 
            this.buMax.Location = new System.Drawing.Point(30, 386);
            this.buMax.Name = "buMax";
            this.buMax.Size = new System.Drawing.Size(75, 23);
            this.buMax.TabIndex = 5;
            this.buMax.Text = "clear";
            this.buMax.UseVisualStyleBackColor = true;
            this.buMax.Click += new System.EventHandler(this.buMax_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cButton
            // 
            this.cButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton.Image = ((System.Drawing.Image)(resources.GetObject("cButton.Image")));
            this.cButton.Location = new System.Drawing.Point(44, 117);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(207, 133);
            this.cButton.TabIndex = 6;
            this.cButton.UseVisualStyleBackColor = true;
            // 
            // btnWow
            // 
            this.btnWow.Location = new System.Drawing.Point(119, 11);
            this.btnWow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWow.Name = "btnWow";
            this.btnWow.Size = new System.Drawing.Size(139, 33);
            this.btnWow.TabIndex = 5;
            this.btnWow.Text = "wow";
            this.btnWow.UseVisualStyleBackColor = true;
            this.btnWow.Click += new System.EventHandler(this.btnWow_Click);
            // 
            // WebBrowserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
<<<<<<< Updated upstream
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 432);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.button2);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 432);
            this.Controls.Add(this.buMax);
>>>>>>> Stashed changes
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wbrDisplay);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
<<<<<<< Updated upstream
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
=======
>>>>>>> Stashed changes
            this.Name = "WebBrowserGUI";
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.WebBrowser wbrDisplay;
        private System.Windows.Forms.Button button1;
<<<<<<< Updated upstream
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cButton;
=======
        private System.Windows.Forms.Button buMax;
>>>>>>> Stashed changes
    }
}

