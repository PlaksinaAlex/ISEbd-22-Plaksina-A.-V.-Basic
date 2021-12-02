using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Lab1_Plaksina
{
	public partial class FormAerodrom : Form
	{
		private readonly AerodromCollection aerodromCollection;

		private readonly Logger logger;
		public FormAerodrom()
		{
			InitializeComponent();
			aerodromCollection = new AerodromCollection(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
			logger = LogManager.GetCurrentClassLogger();
			Draw();
		}

		private void ReloadLevels()
		{
			int index = listBoxAerodrom.SelectedIndex;
			listBoxAerodrom.Items.Clear();

			for (int i = 0; i < aerodromCollection.Keys.Count; i++)
			{
				listBoxAerodrom.Items.Add(aerodromCollection.Keys[i]);
			}

			if (listBoxAerodrom.Items.Count > 0 && (index == -1 || index >=
		   listBoxAerodrom.Items.Count))
			{
				listBoxAerodrom.SelectedIndex = 0;
			}

			else if (listBoxAerodrom.Items.Count > 0 && index > -1 && index <
		   listBoxAerodrom.Items.Count)
			{
				listBoxAerodrom.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxAerodrom.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxAerodrom.Width, pictureBoxAerodrom.Height);
				Graphics gr = Graphics.FromImage(bmp);
				aerodromCollection[listBoxAerodrom.SelectedItem.ToString()].Draw(gr);
				pictureBoxAerodrom.Image = bmp;
			}

		}

		private void buttonTakeAirplane_Click(object sender, EventArgs e)
		{
			if (listBoxAerodrom.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				try
				{
					var aer = aerodromCollection[listBoxAerodrom.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
					if (aer != null)
					{
						FormAerobus form = new FormAerobus();
						form.SetAir(aer);
						form.ShowDialog();
						logger.Info($"Изъят автомобиль {aer} с места {maskedTextBox.Text}");
						Draw();
					}
				}
				catch (AerodromNotFoundException ex)
				{
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn("Не найден самолет");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void buttonAddAerodrom_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
			{
				MessageBox.Show("Введите название аэродрома", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				logger.Warn("Было введено пустное название аэродрома");
				return;
			}
			logger.Info($"Добавили аэродром {textBoxNewLevelName.Text}");
			aerodromCollection.AddAerodrom(textBoxNewLevelName.Text);
			ReloadLevels();
		}
		private void buttonDelAerodrom_Click(object sender, EventArgs e)
		{
			if (listBoxAerodrom.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить аэродром { listBoxAerodrom.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
				{
					logger.Info($"Удалили аэродром {listBoxAerodrom.SelectedItem.ToString()}");
					aerodromCollection.DelAerodrom(textBoxNewLevelName.Text);
					ReloadLevels();
				}
			}
		}

		private void listBoxAerodrom_SelectedIndexChanged(object sender, EventArgs e)
		{
			logger.Info($"Перешли на аэродром {listBoxAerodrom.SelectedItem.ToString()}");
			Draw();
		}

		private void buttonAddAir_Click(object sender, EventArgs e)
		{
			var formAerobusConfig = new FormAerobusConfig();
			formAerobusConfig.AddEvent(AddAir);
			formAerobusConfig.Show();
		}

		private void AddAir(Vehicle aer)
		{
			if (aer != null && listBoxAerodrom.SelectedIndex > -1)
			{
				try
				{
					if ((aerodromCollection[listBoxAerodrom.SelectedItem.ToString()]) + aer)
					{
						Draw();
						logger.Info($"Добавлен самолет {aer}");
					}
					else
					{
						logger.Warn("Самолет не удалось поставить");
						MessageBox.Show("Самолет не удалось поставить");
					}

					Draw();
				}
				catch (AerodromOverflowException ex)
				{
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
					logger.Warn("Аэродром переполнен");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					aerodromCollection.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					aerodromCollection.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName);
					ReloadLevels(); Draw();
				}
				catch (AerodromOccupiedPlaceException ex)
				{
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
