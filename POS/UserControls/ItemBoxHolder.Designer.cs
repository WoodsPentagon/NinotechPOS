﻿namespace POS.UserControls
{
    partial class ItemBoxHolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBoxHolder));
            this.nameTxt = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.barcodeTxt = new System.Windows.Forms.Label();
            this.serialTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(0, 110);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(0);
            this.nameTxt.MinimumSize = new System.Drawing.Size(100, 20);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(130, 20);
            this.nameTxt.TabIndex = 6;
            this.nameTxt.Text = "Name";
            this.nameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTxt.BackColor = System.Drawing.Color.Yellow;
            this.quantityTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxt.Location = new System.Drawing.Point(82, 0);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(51, 10);
            this.quantityTxt.TabIndex = 3;
            this.quantityTxt.Text = "quantity";
            this.quantityTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTxt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.priceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(0, 0);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(82, 10);
            this.priceTxt.TabIndex = 0;
            this.priceTxt.Text = "Price";
            this.priceTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(1, 11);
            this.picture.Margin = new System.Windows.Forms.Padding(1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(127, 79);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.barcodeTxt.BackColor = System.Drawing.Color.CadetBlue;
            this.barcodeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTxt.ForeColor = System.Drawing.Color.Black;
            this.barcodeTxt.Location = new System.Drawing.Point(0, 91);
            this.barcodeTxt.Margin = new System.Windows.Forms.Padding(0);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(65, 19);
            this.barcodeTxt.TabIndex = 4;
            this.barcodeTxt.Text = "barcode";
            this.barcodeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialTxt
            // 
            this.serialTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.serialTxt.BackColor = System.Drawing.Color.LimeGreen;
            this.serialTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialTxt.ForeColor = System.Drawing.Color.Black;
            this.serialTxt.Location = new System.Drawing.Point(65, 91);
            this.serialTxt.Margin = new System.Windows.Forms.Padding(0);
            this.serialTxt.Name = "serialTxt";
            this.serialTxt.Size = new System.Drawing.Size(65, 19);
            this.serialTxt.TabIndex = 5;
            this.serialTxt.Text = "label3\r\nlabel3";
            this.serialTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemBoxHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.serialTxt);
            this.Controls.Add(this.barcodeTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.picture);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ItemBoxHolder";
            this.Size = new System.Drawing.Size(130, 130);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label quantityTxt;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label barcodeTxt;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label serialTxt;
    }
}
