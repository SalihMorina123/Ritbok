
namespace ritbooook
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
            this.färg_val = new System.Windows.Forms.Panel();
            this.size = new System.Windows.Forms.Button();
            this.btn_rensa = new System.Windows.Forms.Button();
            this.färg_väjare = new System.Windows.Forms.PictureBox();
            this.btn_färg = new System.Windows.Forms.Button();
            this.btn_linje = new System.Windows.Forms.Button();
            this.btn_rekt = new System.Windows.Forms.Button();
            this.btn_cirkel = new System.Windows.Forms.Button();
            this.btn_Sudd = new System.Windows.Forms.Button();
            this.btn_penna = new System.Windows.Forms.Button();
            this.btn_fylla = new System.Windows.Forms.Button();
            this.val_färg = new System.Windows.Forms.Button();
            this.bild = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.färg_val.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.färg_väjare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bild)).BeginInit();
            this.SuspendLayout();
            // 
            // färg_val
            // 
            this.färg_val.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.färg_val.Controls.Add(this.button1);
            this.färg_val.Controls.Add(this.size);
            this.färg_val.Controls.Add(this.btn_rensa);
            this.färg_val.Controls.Add(this.färg_väjare);
            this.färg_val.Controls.Add(this.btn_färg);
            this.färg_val.Controls.Add(this.btn_linje);
            this.färg_val.Controls.Add(this.btn_rekt);
            this.färg_val.Controls.Add(this.btn_cirkel);
            this.färg_val.Controls.Add(this.btn_Sudd);
            this.färg_val.Controls.Add(this.btn_penna);
            this.färg_val.Controls.Add(this.btn_fylla);
            this.färg_val.Controls.Add(this.val_färg);
            this.färg_val.Dock = System.Windows.Forms.DockStyle.Right;
            this.färg_val.Location = new System.Drawing.Point(784, 0);
            this.färg_val.Name = "färg_val";
            this.färg_val.Size = new System.Drawing.Size(200, 661);
            this.färg_val.TabIndex = 0;
            // 
            // size
            // 
            this.size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.size.FlatAppearance.BorderSize = 4;
            this.size.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.size.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.size.ForeColor = System.Drawing.Color.White;
            this.size.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.size.Location = new System.Drawing.Point(111, 333);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(77, 30);
            this.size.TabIndex = 9;
            this.size.Text = "storlek 5";
            this.size.UseVisualStyleBackColor = true;
            this.size.Click += new System.EventHandler(this.size_Click);
            // 
            // btn_rensa
            // 
            this.btn_rensa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rensa.FlatAppearance.BorderSize = 4;
            this.btn_rensa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_rensa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_rensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rensa.ForeColor = System.Drawing.Color.White;
            this.btn_rensa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rensa.Location = new System.Drawing.Point(65, 369);
            this.btn_rensa.Name = "btn_rensa";
            this.btn_rensa.Size = new System.Drawing.Size(77, 30);
            this.btn_rensa.TabIndex = 8;
            this.btn_rensa.Text = "Rensa";
            this.btn_rensa.UseVisualStyleBackColor = true;
            this.btn_rensa.Click += new System.EventHandler(this.btn_rensa_Click);
            // 
            // färg_väjare
            // 
            this.färg_väjare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.färg_väjare.Image = global::ritbooook.Properties.Resources.color_palette;
            this.färg_väjare.Location = new System.Drawing.Point(0, 468);
            this.färg_väjare.Name = "färg_väjare";
            this.färg_väjare.Size = new System.Drawing.Size(200, 193);
            this.färg_väjare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.färg_väjare.TabIndex = 8;
            this.färg_väjare.TabStop = false;
            this.färg_väjare.MouseClick += new System.Windows.Forms.MouseEventHandler(this.färg_väjare_MouseClick);
            // 
            // btn_färg
            // 
            this.btn_färg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_färg.FlatAppearance.BorderSize = 4;
            this.btn_färg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_färg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_färg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_färg.ForeColor = System.Drawing.Color.White;
            this.btn_färg.Image = global::ritbooook.Properties.Resources.pall2;
            this.btn_färg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_färg.Location = new System.Drawing.Point(17, 33);
            this.btn_färg.Name = "btn_färg";
            this.btn_färg.Size = new System.Drawing.Size(77, 64);
            this.btn_färg.TabIndex = 1;
            this.btn_färg.Text = "Färg";
            this.btn_färg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_färg.UseVisualStyleBackColor = true;
            this.btn_färg.Click += new System.EventHandler(this.btn_färg_Click);
            // 
            // btn_linje
            // 
            this.btn_linje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_linje.FlatAppearance.BorderSize = 4;
            this.btn_linje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_linje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_linje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_linje.ForeColor = System.Drawing.Color.White;
            this.btn_linje.Image = global::ritbooook.Properties.Resources.linje1;
            this.btn_linje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_linje.Location = new System.Drawing.Point(111, 192);
            this.btn_linje.Name = "btn_linje";
            this.btn_linje.Size = new System.Drawing.Size(77, 64);
            this.btn_linje.TabIndex = 7;
            this.btn_linje.Text = "Linje";
            this.btn_linje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_linje.UseVisualStyleBackColor = true;
            this.btn_linje.Click += new System.EventHandler(this.btn_linje_Click);
            // 
            // btn_rekt
            // 
            this.btn_rekt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rekt.FlatAppearance.BorderSize = 4;
            this.btn_rekt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_rekt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_rekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rekt.ForeColor = System.Drawing.Color.White;
            this.btn_rekt.Image = global::ritbooook.Properties.Resources.rek1;
            this.btn_rekt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rekt.Location = new System.Drawing.Point(65, 262);
            this.btn_rekt.Name = "btn_rekt";
            this.btn_rekt.Size = new System.Drawing.Size(77, 64);
            this.btn_rekt.TabIndex = 6;
            this.btn_rekt.Text = "Rektangel";
            this.btn_rekt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rekt.UseVisualStyleBackColor = true;
            this.btn_rekt.Click += new System.EventHandler(this.btn_rekt_Click);
            // 
            // btn_cirkel
            // 
            this.btn_cirkel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cirkel.FlatAppearance.BorderSize = 4;
            this.btn_cirkel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cirkel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_cirkel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cirkel.ForeColor = System.Drawing.Color.White;
            this.btn_cirkel.Image = global::ritbooook.Properties.Resources.cirk1;
            this.btn_cirkel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cirkel.Location = new System.Drawing.Point(17, 192);
            this.btn_cirkel.Name = "btn_cirkel";
            this.btn_cirkel.Size = new System.Drawing.Size(77, 64);
            this.btn_cirkel.TabIndex = 5;
            this.btn_cirkel.Text = "Cirkel";
            this.btn_cirkel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cirkel.UseVisualStyleBackColor = true;
            this.btn_cirkel.Click += new System.EventHandler(this.btn_cirkel_Click);
            // 
            // btn_Sudd
            // 
            this.btn_Sudd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sudd.FlatAppearance.BorderSize = 4;
            this.btn_Sudd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Sudd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Sudd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sudd.ForeColor = System.Drawing.Color.White;
            this.btn_Sudd.Image = global::ritbooook.Properties.Resources.sudd11;
            this.btn_Sudd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sudd.Location = new System.Drawing.Point(111, 112);
            this.btn_Sudd.Name = "btn_Sudd";
            this.btn_Sudd.Size = new System.Drawing.Size(77, 64);
            this.btn_Sudd.TabIndex = 4;
            this.btn_Sudd.Text = "Sudd";
            this.btn_Sudd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sudd.UseVisualStyleBackColor = true;
            this.btn_Sudd.Click += new System.EventHandler(this.btn_Sudd_Click);
            // 
            // btn_penna
            // 
            this.btn_penna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_penna.FlatAppearance.BorderSize = 4;
            this.btn_penna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_penna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_penna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_penna.ForeColor = System.Drawing.Color.White;
            this.btn_penna.Image = global::ritbooook.Properties.Resources.penc11;
            this.btn_penna.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_penna.Location = new System.Drawing.Point(17, 112);
            this.btn_penna.Name = "btn_penna";
            this.btn_penna.Size = new System.Drawing.Size(77, 64);
            this.btn_penna.TabIndex = 3;
            this.btn_penna.Text = "Penna";
            this.btn_penna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_penna.UseVisualStyleBackColor = true;
            this.btn_penna.Click += new System.EventHandler(this.btn_penna_Click);
            // 
            // btn_fylla
            // 
            this.btn_fylla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fylla.FlatAppearance.BorderSize = 4;
            this.btn_fylla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_fylla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_fylla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fylla.ForeColor = System.Drawing.Color.White;
            this.btn_fylla.Image = global::ritbooook.Properties.Resources.fill2;
            this.btn_fylla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fylla.Location = new System.Drawing.Point(111, 33);
            this.btn_fylla.Name = "btn_fylla";
            this.btn_fylla.Size = new System.Drawing.Size(77, 64);
            this.btn_fylla.TabIndex = 2;
            this.btn_fylla.Text = "Fylla";
            this.btn_fylla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fylla.UseVisualStyleBackColor = true;
            this.btn_fylla.Click += new System.EventHandler(this.btn_fylla_Click);
            // 
            // val_färg
            // 
            this.val_färg.BackColor = System.Drawing.Color.White;
            this.val_färg.Location = new System.Drawing.Point(65, 405);
            this.val_färg.Name = "val_färg";
            this.val_färg.Size = new System.Drawing.Size(77, 57);
            this.val_färg.TabIndex = 0;
            this.val_färg.UseVisualStyleBackColor = false;
            // 
            // bild
            // 
            this.bild.BackColor = System.Drawing.Color.White;
            this.bild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bild.Location = new System.Drawing.Point(0, 0);
            this.bild.Name = "bild";
            this.bild.Size = new System.Drawing.Size(984, 661);
            this.bild.TabIndex = 1;
            this.bild.TabStop = false;
            this.bild.Click += new System.EventHandler(this.bild_Click);
            this.bild.Paint += new System.Windows.Forms.PaintEventHandler(this.bild_Paint);
            this.bild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bild_MouseClick);
            this.bild.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bild_MouseDown);
            this.bild.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bild_MouseMove);
            this.bild.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bild_MouseUp);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(17, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "storlek 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.färg_val);
            this.Controls.Add(this.bild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.färg_val.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.färg_väjare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel färg_val;
        private System.Windows.Forms.Button btn_färg;
        private System.Windows.Forms.Button val_färg;
        private System.Windows.Forms.PictureBox bild;
        private System.Windows.Forms.Button btn_cirkel;
        private System.Windows.Forms.Button btn_Sudd;
        private System.Windows.Forms.Button btn_penna;
        private System.Windows.Forms.Button btn_fylla;
        private System.Windows.Forms.Button btn_linje;
        private System.Windows.Forms.Button btn_rekt;
        private System.Windows.Forms.PictureBox färg_väjare;
        private System.Windows.Forms.Button btn_rensa;
        private System.Windows.Forms.Button size;
        private System.Windows.Forms.Button button1;
    }
}

