namespace WebBrowser
{
    partial class Form_WebBrowser
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Web = new System.Windows.Forms.TextBox();
            this.wb_Browser = new System.Windows.Forms.WebBrowser();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(96, 36);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Forward
            // 
            this.btn_Forward.Location = new System.Drawing.Point(514, 13);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(70, 37);
            this.btn_Forward.TabIndex = 1;
            this.btn_Forward.Text = "Forward";
            this.btn_Forward.UseVisualStyleBackColor = true;
            this.btn_Forward.Click += new System.EventHandler(this.btn_Forward_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(114, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(80, 38);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_Web
            // 
            this.txt_Web.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Web.Location = new System.Drawing.Point(200, 14);
            this.txt_Web.Multiline = true;
            this.txt_Web.Name = "txt_Web";
            this.txt_Web.Size = new System.Drawing.Size(233, 36);
            this.txt_Web.TabIndex = 4;
            this.txt_Web.TextChanged += new System.EventHandler(this.txt_Web_TextChanged);
            // 
            // wb_Browser
            // 
            this.wb_Browser.Location = new System.Drawing.Point(1, 56);
            this.wb_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Browser.Name = "wb_Browser";
            this.wb_Browser.Size = new System.Drawing.Size(673, 390);
            this.wb_Browser.TabIndex = 5;
            this.wb_Browser.Url = new System.Uri("http://www.google.co.uk", System.UriKind.Absolute);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(439, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(69, 38);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(590, 13);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(75, 37);
            this.btn_MainMenu.TabIndex = 7;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click_1);
            // 
            // Form_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 448);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.wb_Browser);
            this.Controls.Add(this.txt_Web);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Forward);
            this.Controls.Add(this.btn_Back);
            this.Name = "Form_WebBrowser";
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txt_Web;
        private System.Windows.Forms.WebBrowser wb_Browser;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_MainMenu;
    }
}

