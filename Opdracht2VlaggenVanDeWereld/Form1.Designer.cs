namespace Opdracht2VlaggenVanDeWereld
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
            this.listBoxFlags = new System.Windows.Forms.ListBox();
            this.flagPicture = new System.Windows.Forms.PictureBox();
            this.buttonSelectorView = new System.Windows.Forms.Button();
            this.buttonSelectorMenu = new System.Windows.Forms.Button();
            this.buttonSelectorTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flagPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFlags
            // 
            this.listBoxFlags.FormattingEnabled = true;
            this.listBoxFlags.Location = new System.Drawing.Point(12, 343);
            this.listBoxFlags.Name = "listBoxFlags";
            this.listBoxFlags.Size = new System.Drawing.Size(729, 95);
            this.listBoxFlags.TabIndex = 0;
            this.listBoxFlags.SelectedIndexChanged += new System.EventHandler(this.listBoxFlags_SelectedIndexChanged);
            // 
            // flagPicture
            // 
            this.flagPicture.Location = new System.Drawing.Point(12, 12);
            this.flagPicture.Name = "flagPicture";
            this.flagPicture.Size = new System.Drawing.Size(776, 324);
            this.flagPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagPicture.TabIndex = 1;
            this.flagPicture.TabStop = false;
            // 
            // buttonSelectorView
            // 
            this.buttonSelectorView.Location = new System.Drawing.Point(278, 24);
            this.buttonSelectorView.Name = "buttonSelectorView";
            this.buttonSelectorView.Size = new System.Drawing.Size(118, 23);
            this.buttonSelectorView.TabIndex = 2;
            this.buttonSelectorView.Text = "view flags";
            this.buttonSelectorView.UseVisualStyleBackColor = true;
            this.buttonSelectorView.Click += new System.EventHandler(this.buttonSelectorView_Click);
            // 
            // buttonSelectorMenu
            // 
            this.buttonSelectorMenu.Location = new System.Drawing.Point(747, 343);
            this.buttonSelectorMenu.Name = "buttonSelectorMenu";
            this.buttonSelectorMenu.Size = new System.Drawing.Size(41, 23);
            this.buttonSelectorMenu.TabIndex = 3;
            this.buttonSelectorMenu.Text = "menu";
            this.buttonSelectorMenu.UseVisualStyleBackColor = true;
            this.buttonSelectorMenu.Click += new System.EventHandler(this.buttonSelectorMenu_Click);
            // 
            // buttonSelectorTest
            // 
            this.buttonSelectorTest.Location = new System.Drawing.Point(402, 24);
            this.buttonSelectorTest.Name = "buttonSelectorTest";
            this.buttonSelectorTest.Size = new System.Drawing.Size(118, 23);
            this.buttonSelectorTest.TabIndex = 4;
            this.buttonSelectorTest.Text = "test flag knowledge";
            this.buttonSelectorTest.UseVisualStyleBackColor = true;
            this.buttonSelectorTest.Click += new System.EventHandler(this.buttonSelectorTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectorTest);
            this.Controls.Add(this.buttonSelectorMenu);
            this.Controls.Add(this.buttonSelectorView);
            this.Controls.Add(this.flagPicture);
            this.Controls.Add(this.listBoxFlags);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.flagPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFlags;
        private System.Windows.Forms.PictureBox flagPicture;
        private System.Windows.Forms.Button buttonSelectorView;
        private System.Windows.Forms.Button buttonSelectorMenu;
        private System.Windows.Forms.Button buttonSelectorTest;
    }
}

