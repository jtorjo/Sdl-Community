﻿namespace Sdl.Community.SdlDataProtectionSuite.SdlProjectAnonymizer.Ui
{
	partial class AnonymizerSettingsControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.TableLayoutPanel mainPanel;

		private System.Windows.Forms.DataGridView expressionsGrid;

		private System.Windows.Forms.Button importBtn;

		private System.Windows.Forms.Button exportBtn;

		private System.Windows.Forms.Label encryptionLbl;

		private System.Windows.Forms.TextBox encryptionBox;

		private System.Windows.Forms.TableLayoutPanel descriptionPanel;

		private System.Windows.Forms.Label descriptionLbl;

		private System.Windows.Forms.CheckBox selectAll;

		private System.Windows.Forms.Label encryptedMessage;

		private System.Windows.Forms.PictureBox lockPictureBox;

		private System.Windows.Forms.TableLayoutPanel encryptedPanel;

		private System.Windows.Forms.Panel decryptionPanel;

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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.expressionsGrid = new System.Windows.Forms.DataGridView();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.encryptionLbl = new System.Windows.Forms.Label();
            this.encryptionBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.selectAll = new System.Windows.Forms.CheckBox();
            this.addNewPatternButton = new System.Windows.Forms.Button();
            this.encryptedPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.decryptionPanel = new System.Windows.Forms.Panel();
            this.encryptedMessage = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsGrid)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            this.encryptedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 3;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainPanel.Controls.Add(this.expressionsGrid, 0, 1);
            this.mainPanel.Controls.Add(this.importBtn, 0, 2);
            this.mainPanel.Controls.Add(this.exportBtn, 1, 2);
            this.mainPanel.Controls.Add(this.encryptionLbl, 0, 3);
            this.mainPanel.Controls.Add(this.encryptionBox, 1, 3);
            this.mainPanel.Controls.Add(this.descriptionPanel, 0, 0);
            this.mainPanel.Controls.Add(this.addNewPatternButton, 2, 2);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainPanel.Size = new System.Drawing.Size(1244, 658);
            this.mainPanel.TabIndex = 0;
            // 
            // expressionsGrid
            // 
            this.expressionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPanel.SetColumnSpan(this.expressionsGrid, 3);
            this.expressionsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expressionsGrid.Location = new System.Drawing.Point(4, 202);
            this.expressionsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expressionsGrid.Name = "expressionsGrid";
            this.expressionsGrid.Size = new System.Drawing.Size(1234, 286);
            this.expressionsGrid.TabIndex = 1;
            this.expressionsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expressionsGrid_KeyDown);
            // 
            // importBtn
            // 
            this.importBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.importBtn.Location = new System.Drawing.Point(4, 508);
            this.importBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(164, 35);
            this.importBtn.TabIndex = 2;
            this.importBtn.Text = "Import rules(s)";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportBtn.Location = new System.Drawing.Point(377, 508);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(162, 35);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Text = "Export rules(s)";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // encryptionLbl
            // 
            this.encryptionLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encryptionLbl.AutoSize = true;
            this.encryptionLbl.Location = new System.Drawing.Point(4, 598);
            this.encryptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encryptionLbl.Name = "encryptionLbl";
            this.encryptionLbl.Size = new System.Drawing.Size(0, 20);
            this.encryptionLbl.TabIndex = 4;
            // 
            // encryptionBox
            // 
            this.encryptionBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.encryptionBox.Location = new System.Drawing.Point(377, 595);
            this.encryptionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encryptionBox.Name = "encryptionBox";
            this.encryptionBox.PasswordChar = '*';
            this.encryptionBox.Size = new System.Drawing.Size(319, 26);
            this.encryptionBox.TabIndex = 5;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.ColumnCount = 1;
            this.mainPanel.SetColumnSpan(this.descriptionPanel, 3);
            this.descriptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.descriptionPanel.Controls.Add(this.descriptionLbl, 0, 0);
            this.descriptionPanel.Controls.Add(this.selectAll, 0, 1);
            this.descriptionPanel.Location = new System.Drawing.Point(4, 5);
            this.descriptionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.RowCount = 2;
            this.descriptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.descriptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.descriptionPanel.Size = new System.Drawing.Size(1234, 187);
            this.descriptionPanel.TabIndex = 6;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(4, 64);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(51, 20);
            this.descriptionLbl.TabIndex = 0;
            this.descriptionLbl.Text = "label1";
            // 
            // selectAll
            // 
            this.selectAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectAll.AutoSize = true;
            this.selectAll.Location = new System.Drawing.Point(4, 156);
            this.selectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(99, 24);
            this.selectAll.TabIndex = 1;
            this.selectAll.Text = "Select all";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.CheckedChanged += new System.EventHandler(this.selectAll_CheckedChanged);
            // 
            // addNewPatternButton
            // 
            this.addNewPatternButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addNewPatternButton.Location = new System.Drawing.Point(1128, 508);
            this.addNewPatternButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewPatternButton.Name = "addNewPatternButton";
            this.addNewPatternButton.Size = new System.Drawing.Size(112, 35);
            this.addNewPatternButton.TabIndex = 7;
            this.addNewPatternButton.Text = "Add new";
            this.addNewPatternButton.UseVisualStyleBackColor = true;
            this.addNewPatternButton.Click += new System.EventHandler(this.addNewPatternButton_Click);
            // 
            // encryptedPanel
            // 
            this.encryptedPanel.ColumnCount = 3;
            this.encryptedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.encryptedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.encryptedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.encryptedPanel.Controls.Add(this.lockPictureBox, 1, 1);
            this.encryptedPanel.Controls.Add(this.decryptionPanel, 1, 5);
            this.encryptedPanel.Controls.Add(this.encryptedMessage, 1, 3);
            this.encryptedPanel.Location = new System.Drawing.Point(0, 0);
            this.encryptedPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encryptedPanel.Name = "encryptedPanel";
            this.encryptedPanel.RowCount = 8;
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.encryptedPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.encryptedPanel.Size = new System.Drawing.Size(1244, 658);
            this.encryptedPanel.TabIndex = 10;
            this.encryptedPanel.Visible = false;
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lockPictureBox.Location = new System.Drawing.Point(525, 27);
            this.lockPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(194, 203);
            this.lockPictureBox.TabIndex = 8;
            this.lockPictureBox.TabStop = false;
            // 
            // decryptionPanel
            // 
            this.decryptionPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptionPanel.Location = new System.Drawing.Point(365, 324);
            this.decryptionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decryptionPanel.Name = "decryptionPanel";
            this.decryptionPanel.Size = new System.Drawing.Size(513, 49);
            this.decryptionPanel.TabIndex = 9;
            // 
            // encryptedMessage
            // 
            this.encryptedMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptedMessage.AutoEllipsis = true;
            this.encryptedMessage.AutoSize = true;
            this.encryptedMessage.CausesValidation = false;
            this.encryptedMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedMessage.Location = new System.Drawing.Point(286, 257);
            this.encryptedMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encryptedMessage.Name = "encryptedMessage";
            this.encryptedMessage.Size = new System.Drawing.Size(671, 40);
            this.encryptedMessage.TabIndex = 7;
            this.encryptedMessage.Text = "Data encrypted. Unprotect Data before proceeding.";
            this.encryptedMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnonymizerSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.encryptedPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnonymizerSettingsControl";
            this.Size = new System.Drawing.Size(1248, 663);
            //this.Load += new System.EventHandler(this.AnonymizerSettingsControl_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expressionsGrid)).EndInit();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.encryptedPanel.ResumeLayout(false);
            this.encryptedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewPatternButton;
	}
}
