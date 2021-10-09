using System;
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
	public partial class FormParking : Form
	{
		private readonly Parking<Airplane> parking;

		public FormParking()
		{
			InitializeComponent();
			parking = new Parking<Airplane>(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}

		private void buttonSetAirplane_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var airplane = new Airplane(100, 1000, dialog.Color);
				if (parking + airplane != -1)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}

		private void buttonSetAerobus_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var airplane = new Aerobus(100, 1000, dialog.Color, dialogDop.Color, true, true);
					if (parking + airplane != -1)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}
		private void buttonTakeAirplane_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var airplane = parking - Convert.ToInt32(maskedTextBox.Text);
				if (airplane != null)
				{
					FormAerobus form = new FormAerobus();
					form.SetAir(airplane);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
