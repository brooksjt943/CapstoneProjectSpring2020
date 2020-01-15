namespace KioskMenu
{
    partial class MenuForm
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
            this.btnPhotoBooth = new System.Windows.Forms.Button();
            this.btnCellularAutomaton = new System.Windows.Forms.Button();
            this.btnPhotoGallery = new System.Windows.Forms.Button();
            this.btnCloseMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPhotoBooth
            // 
            this.btnPhotoBooth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPhotoBooth.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPhotoBooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoBooth.ForeColor = System.Drawing.Color.LightCoral;
            this.btnPhotoBooth.Location = new System.Drawing.Point(595, 182);
            this.btnPhotoBooth.Name = "btnPhotoBooth";
            this.btnPhotoBooth.Size = new System.Drawing.Size(160, 75);
            this.btnPhotoBooth.TabIndex = 0;
            this.btnPhotoBooth.Text = "Photo Booth";
            this.btnPhotoBooth.UseVisualStyleBackColor = false;
            this.btnPhotoBooth.Click += new System.EventHandler(this.btnPhotoBooth_Click);
            // 
            // btnCellularAutomaton
            // 
            this.btnCellularAutomaton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCellularAutomaton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCellularAutomaton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCellularAutomaton.ForeColor = System.Drawing.Color.LightCoral;
            this.btnCellularAutomaton.Location = new System.Drawing.Point(595, 382);
            this.btnCellularAutomaton.Name = "btnCellularAutomaton";
            this.btnCellularAutomaton.Size = new System.Drawing.Size(160, 75);
            this.btnCellularAutomaton.TabIndex = 1;
            this.btnCellularAutomaton.Text = "Cellular Automaton";
            this.btnCellularAutomaton.UseVisualStyleBackColor = false;
            this.btnCellularAutomaton.Click += new System.EventHandler(this.btnCellularAutomaton_Click);
            // 
            // btnPhotoGallery
            // 
            this.btnPhotoGallery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPhotoGallery.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPhotoGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotoGallery.ForeColor = System.Drawing.Color.LightCoral;
            this.btnPhotoGallery.Location = new System.Drawing.Point(595, 282);
            this.btnPhotoGallery.Name = "btnPhotoGallery";
            this.btnPhotoGallery.Size = new System.Drawing.Size(160, 75);
            this.btnPhotoGallery.TabIndex = 2;
            this.btnPhotoGallery.Text = "Photo Gallery";
            this.btnPhotoGallery.UseVisualStyleBackColor = false;
            this.btnPhotoGallery.Click += new System.EventHandler(this.btnPhotoGallery_Click);
            // 
            // btnCloseMenu
            // 
            this.btnCloseMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCloseMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCloseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMenu.ForeColor = System.Drawing.Color.LightCoral;
            this.btnCloseMenu.Location = new System.Drawing.Point(595, 482);
            this.btnCloseMenu.Name = "btnCloseMenu";
            this.btnCloseMenu.Size = new System.Drawing.Size(160, 75);
            this.btnCloseMenu.TabIndex = 3;
            this.btnCloseMenu.Text = "Close Menu";
            this.btnCloseMenu.UseVisualStyleBackColor = false;
            this.btnCloseMenu.Click += new System.EventHandler(this.btnCloseMenu_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(424, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 72);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kiosk Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseMenu);
            this.Controls.Add(this.btnPhotoGallery);
            this.Controls.Add(this.btnCellularAutomaton);
            this.Controls.Add(this.btnPhotoBooth);
            this.Name = "MenuForm";
            this.Text = "Kiosk Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhotoBooth;
        private System.Windows.Forms.Button btnCellularAutomaton;
        private System.Windows.Forms.Button btnPhotoGallery;
        private System.Windows.Forms.Button btnCloseMenu;
        private System.Windows.Forms.Label label2;
    }
}

