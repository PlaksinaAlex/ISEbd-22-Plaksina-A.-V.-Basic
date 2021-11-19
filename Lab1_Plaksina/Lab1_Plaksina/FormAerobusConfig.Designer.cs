
namespace Lab1_Plaksina
{
	partial class FormAerobusConfig
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxWindow = new System.Windows.Forms.CheckBox();
			this.checkBoxSecondFloor = new System.Windows.Forms.CheckBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxAirConfig = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label_aerobus = new System.Windows.Forms.Label();
			this.label_airplane = new System.Windows.Forms.Label();
			this.panelAirplane = new System.Windows.Forms.Panel();
			this.groupBoxColor = new System.Windows.Forms.GroupBox();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.panelLime = new System.Windows.Forms.Panel();
			this.panelPurple = new System.Windows.Forms.Panel();
			this.panelSilver = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelTeal = new System.Windows.Forms.Panel();
			this.panelFuchsia = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirConfig)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panelAirplane.SuspendLayout();
			this.groupBoxColor.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxWindow);
			this.groupBox1.Controls.Add(this.checkBoxSecondFloor);
			this.groupBox1.Controls.Add(this.numericUpDownWeight);
			this.groupBox1.Controls.Add(this.numericUpDownMaxSpeed);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(26, 244);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(326, 116);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры";
			// 
			// checkBoxWindow
			// 
			this.checkBoxWindow.AutoSize = true;
			this.checkBoxWindow.Location = new System.Drawing.Point(187, 51);
			this.checkBoxWindow.Name = "checkBoxWindow";
			this.checkBoxWindow.Size = new System.Drawing.Size(52, 17);
			this.checkBoxWindow.TabIndex = 5;
			this.checkBoxWindow.Text = "Окно";
			this.checkBoxWindow.UseVisualStyleBackColor = true;
			// 
			// checkBoxSecondFloor
			// 
			this.checkBoxSecondFloor.AutoSize = true;
			this.checkBoxSecondFloor.Location = new System.Drawing.Point(187, 28);
			this.checkBoxSecondFloor.Name = "checkBoxSecondFloor";
			this.checkBoxSecondFloor.Size = new System.Drawing.Size(90, 17);
			this.checkBoxSecondFloor.TabIndex = 4;
			this.checkBoxSecondFloor.Text = "Второй этаж";
			this.checkBoxSecondFloor.UseVisualStyleBackColor = true;
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(105, 71);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(53, 20);
			this.numericUpDownWeight.TabIndex = 3;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownMaxSpeed
			// 
			this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(105, 25);
			this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
			this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(54, 20);
			this.numericUpDownMaxSpeed.TabIndex = 2;
			this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Вес самолета:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Макс. скорость:";
			// 
			// pictureBoxAirConfig
			// 
			this.pictureBoxAirConfig.Location = new System.Drawing.Point(16, 17);
			this.pictureBoxAirConfig.Name = "pictureBoxAirConfig";
			this.pictureBoxAirConfig.Size = new System.Drawing.Size(244, 137);
			this.pictureBoxAirConfig.TabIndex = 1;
			this.pictureBoxAirConfig.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label_aerobus);
			this.groupBox2.Controls.Add(this.label_airplane);
			this.groupBox2.Location = new System.Drawing.Point(12, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(158, 134);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тип самолета";
			// 
			// label_aerobus
			// 
			this.label_aerobus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_aerobus.Location = new System.Drawing.Point(23, 86);
			this.label_aerobus.Name = "label_aerobus";
			this.label_aerobus.Size = new System.Drawing.Size(98, 27);
			this.label_aerobus.TabIndex = 1;
			this.label_aerobus.Text = "Аэробус";
			this.label_aerobus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_aerobus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_aerobus_MouseDown);
			// 
			// label_airplane
			// 
			this.label_airplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_airplane.Location = new System.Drawing.Point(23, 29);
			this.label_airplane.Name = "label_airplane";
			this.label_airplane.Size = new System.Drawing.Size(98, 41);
			this.label_airplane.TabIndex = 0;
			this.label_airplane.Text = "Обычный самолет";
			this.label_airplane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_airplane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_airplane_MouseDown);
			// 
			// panelAirplane
			// 
			this.panelAirplane.AllowDrop = true;
			this.panelAirplane.Controls.Add(this.pictureBoxAirConfig);
			this.panelAirplane.Location = new System.Drawing.Point(187, 32);
			this.panelAirplane.Name = "panelAirplane";
			this.panelAirplane.Size = new System.Drawing.Size(277, 170);
			this.panelAirplane.TabIndex = 3;
			this.panelAirplane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAirplane_DragDrop);
			this.panelAirplane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAirplane_DragEnter);
			// 
			// groupBoxColor
			// 
			this.groupBoxColor.Controls.Add(this.panelBlack);
			this.groupBoxColor.Controls.Add(this.panelRed);
			this.groupBoxColor.Controls.Add(this.panelLime);
			this.groupBoxColor.Controls.Add(this.panelPurple);
			this.groupBoxColor.Controls.Add(this.panelSilver);
			this.groupBoxColor.Controls.Add(this.panelYellow);
			this.groupBoxColor.Controls.Add(this.panelTeal);
			this.groupBoxColor.Controls.Add(this.panelFuchsia);
			this.groupBoxColor.Controls.Add(this.labelDopColor);
			this.groupBoxColor.Controls.Add(this.labelBaseColor);
			this.groupBoxColor.Location = new System.Drawing.Point(491, 32);
			this.groupBoxColor.Name = "groupBoxColor";
			this.groupBoxColor.Size = new System.Drawing.Size(278, 194);
			this.groupBoxColor.TabIndex = 4;
			this.groupBoxColor.TabStop = false;
			this.groupBoxColor.Text = "Цвета";
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlack.Location = new System.Drawing.Point(208, 135);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(40, 40);
			this.panelBlack.TabIndex = 9;
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRed.Location = new System.Drawing.Point(26, 135);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(40, 40);
			this.panelRed.TabIndex = 8;
			// 
			// panelLime
			// 
			this.panelLime.BackColor = System.Drawing.Color.Lime;
			this.panelLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLime.Location = new System.Drawing.Point(82, 135);
			this.panelLime.Name = "panelLime";
			this.panelLime.Size = new System.Drawing.Size(40, 40);
			this.panelLime.TabIndex = 7;
			// 
			// panelPurple
			// 
			this.panelPurple.BackColor = System.Drawing.Color.Purple;
			this.panelPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPurple.Location = new System.Drawing.Point(142, 135);
			this.panelPurple.Name = "panelPurple";
			this.panelPurple.Size = new System.Drawing.Size(40, 40);
			this.panelPurple.TabIndex = 6;
			// 
			// panelSilver
			// 
			this.panelSilver.BackColor = System.Drawing.Color.Silver;
			this.panelSilver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSilver.Location = new System.Drawing.Point(208, 69);
			this.panelSilver.Name = "panelSilver";
			this.panelSilver.Size = new System.Drawing.Size(40, 40);
			this.panelSilver.TabIndex = 5;
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelYellow.Location = new System.Drawing.Point(142, 69);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(40, 40);
			this.panelYellow.TabIndex = 4;
			// 
			// panelTeal
			// 
			this.panelTeal.BackColor = System.Drawing.Color.Teal;
			this.panelTeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTeal.Location = new System.Drawing.Point(82, 69);
			this.panelTeal.Name = "panelTeal";
			this.panelTeal.Size = new System.Drawing.Size(40, 40);
			this.panelTeal.TabIndex = 3;
			// 
			// panelFuchsia
			// 
			this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
			this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFuchsia.Location = new System.Drawing.Point(26, 69);
			this.panelFuchsia.Name = "panelFuchsia";
			this.panelFuchsia.Size = new System.Drawing.Size(40, 40);
			this.panelFuchsia.TabIndex = 2;
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(142, 25);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(106, 23);
			this.labelDopColor.TabIndex = 1;
			this.labelDopColor.Text = "Доп. цвет";
			this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(20, 25);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(102, 23);
			this.labelBaseColor.TabIndex = 0;
			this.labelBaseColor.Text = "Основной цвет";
			this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(618, 300);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(140, 30);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(618, 362);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(140, 30);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormAerobusConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxColor);
			this.Controls.Add(this.panelAirplane);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormAerobusConfig";
			this.Text = "FormAerobusConfig";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirConfig)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.panelAirplane.ResumeLayout(false);
			this.groupBoxColor.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBoxWindow;
		private System.Windows.Forms.CheckBox checkBoxSecondFloor;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxAirConfig;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label_aerobus;
		private System.Windows.Forms.Label label_airplane;
		private System.Windows.Forms.Panel panelAirplane;
		private System.Windows.Forms.GroupBox groupBoxColor;
		private System.Windows.Forms.Panel panelBlack;
		private System.Windows.Forms.Panel panelRed;
		private System.Windows.Forms.Panel panelLime;
		private System.Windows.Forms.Panel panelPurple;
		private System.Windows.Forms.Panel panelSilver;
		private System.Windows.Forms.Panel panelYellow;
		private System.Windows.Forms.Panel panelTeal;
		private System.Windows.Forms.Panel panelFuchsia;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelBaseColor;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
	}
}