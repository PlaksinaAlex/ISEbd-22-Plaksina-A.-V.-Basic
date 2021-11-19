﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Plaksina
{
	public partial class FormAerobusConfig : Form
	{
		Vehicle aer = null;

		private event Action<Vehicle> eventAddAer;

		public FormAerobusConfig()
		{
			InitializeComponent();
			this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelSilver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelTeal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			Color color = (sender as Panel).BackColor;
			(sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			aer.SetMainColor((Color)e.Data.GetData(typeof(Color)));
			DrawTransport();
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (aer is Aerobus)
			{
				(aer as Aerobus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
				DrawTransport();
			}
		}

		private void DrawTransport()
		{
			if (aer != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxAirConfig.Width, pictureBoxAirConfig.Height);
				Graphics gr = Graphics.FromImage(bmp);
				aer.SetPosition(35, 35, pictureBoxAirConfig.Width, pictureBoxAirConfig.Height);
				aer.DrawTransport(gr);
				pictureBoxAirConfig.Image = bmp;
			}
		}

		public void AddEvent(Action<Vehicle> ev)
		{
			if (eventAddAer == null)
			{
				eventAddAer = new Action<Vehicle>(ev);
			}
			else
			{
				eventAddAer += ev;
			}
		}


		private void label_airplane_MouseDown(object sender, MouseEventArgs e)
		{
			label_airplane.DoDragDrop(label_airplane.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void label_aerobus_MouseDown(object sender, MouseEventArgs e)
		{
			label_aerobus.DoDragDrop(label_aerobus.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panelAirplane_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelAirplane_DragDrop(object sender, DragEventArgs e)
		{

			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Обычный самолет":
					aer = new Airplane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
					break;
				case "Аэробус":
					aer = new Aerobus((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxWindow.Checked, checkBoxSecondFloor.Checked);
					break;
			}
			DrawTransport();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			eventAddAer?.Invoke(aer);
			Close();
		}
	}
}
