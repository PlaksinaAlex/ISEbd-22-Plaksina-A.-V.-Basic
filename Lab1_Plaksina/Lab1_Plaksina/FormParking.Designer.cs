﻿namespace Lab1_Plaksina
{
	partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.buttonSetAirplane = new System.Windows.Forms.Button();
			this.buttonSetAerobus = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTakeAirplane = new System.Windows.Forms.Button();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(678, 450);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// buttonSetAirplane
			// 
			this.buttonSetAirplane.Location = new System.Drawing.Point(693, 14);
			this.buttonSetAirplane.Name = "buttonSetAirplane";
			this.buttonSetAirplane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.buttonSetAirplane.Size = new System.Drawing.Size(92, 34);
			this.buttonSetAirplane.TabIndex = 1;
			this.buttonSetAirplane.Text = "припарковать самолет";
			this.buttonSetAirplane.UseVisualStyleBackColor = true;
			this.buttonSetAirplane.Click += new System.EventHandler(this.buttonSetAirplane_Click);
			// 
			// buttonSetAerobus
			// 
			this.buttonSetAerobus.Location = new System.Drawing.Point(693, 64);
			this.buttonSetAerobus.Name = "buttonSetAerobus";
			this.buttonSetAerobus.Size = new System.Drawing.Size(91, 54);
			this.buttonSetAerobus.TabIndex = 2;
			this.buttonSetAerobus.Text = "припарковать аэробус";
			this.buttonSetAerobus.UseVisualStyleBackColor = true;
			this.buttonSetAerobus.Click += new System.EventHandler(this.buttonSetAerobus_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTakeAirplane);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(684, 138);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(114, 93);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать самолет";
			// 
			// buttonTakeAirplane
			// 
			this.buttonTakeAirplane.Location = new System.Drawing.Point(22, 52);
			this.buttonTakeAirplane.Name = "buttonTakeAirplane";
			this.buttonTakeAirplane.Size = new System.Drawing.Size(69, 31);
			this.buttonTakeAirplane.TabIndex = 2;
			this.buttonTakeAirplane.Text = "забрать";
			this.buttonTakeAirplane.UseVisualStyleBackColor = true;
			this.buttonTakeAirplane.Click += new System.EventHandler(this.buttonTakeAirplane_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(54, 26);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(28, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место:";
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSetAerobus);
			this.Controls.Add(this.buttonSetAirplane);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "Парковка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button buttonSetAirplane;
		private System.Windows.Forms.Button buttonSetAerobus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTakeAirplane;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.Label label1;
	}
}