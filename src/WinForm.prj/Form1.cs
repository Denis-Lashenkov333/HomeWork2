using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentApp
{
	public partial class MainForm : Form
	{
		private int _countRows = 0; 
		public MainForm()
		{
			InitializeComponent();
			_cmbCom.Enabled = false;
			_cmbMng.Enabled = false;
			_cmbSkill.Enabled = false;
			// Изменения в checkBox.
			_chkCom.CheckedChanged += _chk_CheckedChanged;
			_chkSkill.CheckedChanged += _chk_CheckedChanged;
			_chkMng.CheckedChanged += _chk_CheckedChanged;

			// Создаем колонки для таблицы.
			DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn lastNameCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn sexCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn comCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn mngCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn skillCol = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn positionCol = new DataGridViewTextBoxColumn();

			nameCol.Name = "Имя";
			lastNameCol.Name = "Фамилия";
			sexCol.Name = "Пол";
			comCol.Name = "Коммуникативность";
			mngCol.Name = "Знакомство с офисными программами";
			skillCol.Name = "Управленческие навыки";
			positionCol.Name = "Должность";

			_dataGridView.Columns.AddRange(new DataGridViewTextBoxColumn[] {nameCol, lastNameCol, sexCol, comCol, mngCol, skillCol, positionCol });

	
		}
		//Проверка checkBox
		private void _chk_CheckedChanged(object sender, EventArgs e)
		{
			if(_chkCom.Checked)
			{
				_cmbCom.Enabled = true;
			}
			else
			{
				_cmbCom.SelectedItem = null;
				_cmbCom.Enabled = false;
			}

			if(_chkSkill.Checked)
			{
				_cmbSkill.Enabled = true;
			}
			else
			{
				_cmbSkill.SelectedItem = null;
				_cmbSkill.Enabled = false;
			}

			if(_chkMng.Checked)
			{
				_cmbMng.Enabled = true;
			}
			else
			{
				_cmbMng.SelectedItem = null;
				_cmbMng.Enabled = false;
			}
		}
		/// Проверка заполнения полей
		private void _btnSave_Click(object sender, EventArgs e)
		{
			if(_txtEnterLastName.Text == "")
			{
				MessageBox.Show("'Введите фамилию", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_txtEnterName.Text == "")
			{
				MessageBox.Show("Введите имя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(!_rdiFemale.Checked && !_rdiMale.Checked)
			{
				MessageBox.Show("Укажите пол", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbPosition.SelectedItem == null)
			{
				MessageBox.Show("Укажите должность", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbCom.Enabled && _cmbCom.SelectedItem == null) 
			{
				MessageBox.Show("Укажите уровень владения компетенций", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbSkill.Enabled && _cmbSkill.SelectedItem == null)
			{
				MessageBox.Show("Укажите уровень владения компетенций", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if(_cmbMng.Enabled && _cmbMng.SelectedItem == null)
			{
				MessageBox.Show("Укажите уровень владения компетенций", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				var result = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

				if(result == DialogResult.Yes)
				{
					_dataGridView.Rows.Add();

					_dataGridView[0, _countRows].Value = _txtEnterName.Text;
					_dataGridView[1, _countRows].Value = _txtEnterLastName.Text;
					_dataGridView[2, _countRows].Value = _rdiFemale.Checked ? "Женский" : "Мужской";
					_dataGridView[3, _countRows].Value = _cmbCom.SelectedItem == null ? "-" : _cmbCom.SelectedItem.ToString();
					_dataGridView[4, _countRows].Value = _cmbSkill.SelectedItem == null ? "-" : _cmbSkill.SelectedItem.ToString();
					_dataGridView[5, _countRows].Value = _cmbMng.SelectedItem == null ? "-" : _cmbMng.SelectedItem.ToString();
					_dataGridView[6, _countRows].Value = _cmbPosition.SelectedItem.ToString();

					_countRows++;
				}
			}

		}
		/// Защита от некорректного ввода
		private void _txtEnterLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}
		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}

		}

		private void _chkEnglishProficiency_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void _txtEnglishProficiency_Click(object sender, EventArgs e)
		{

		}

		private void _grpInfo_Enter(object sender, EventArgs e)
		{

		}

		private void _dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void _txtEnterLastName_TextChanged(object sender, EventArgs e)
		{

		}

		private void _txtLastName_Click(object sender, EventArgs e)
		{

		}

		private void _txtExperience_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void _cmbLevelEnglish_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void _cmbHowMuchExp_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void _txtPosition_Click(object sender, EventArgs e)
		{

		}

		private void _cmbPost_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
