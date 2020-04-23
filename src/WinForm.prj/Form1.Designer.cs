namespace EmploymentApp
{
	partial class MainForm
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
			if(disposing && (components != null))
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
			this._txtLastName = new System.Windows.Forms.Label();
			this._txtEnterLastName = new System.Windows.Forms.TextBox();
			this._txtEnterName = new System.Windows.Forms.TextBox();
			this._txtName = new System.Windows.Forms.Label();
			this._rdiMale = new System.Windows.Forms.RadioButton();
			this._txtSex = new System.Windows.Forms.Label();
			this._rdiFemale = new System.Windows.Forms.RadioButton();
			this._grpInfo = new System.Windows.Forms.GroupBox();
			this._btnSave = new System.Windows.Forms.Button();
			this._cmbPosition = new System.Windows.Forms.ComboBox();
			this._chkMng = new System.Windows.Forms.CheckBox();
			this._txtPosition = new System.Windows.Forms.Label();
			this._chkSkill = new System.Windows.Forms.CheckBox();
			this._chkCom = new System.Windows.Forms.CheckBox();
			this._txtMng = new System.Windows.Forms.Label();
			this._cmbMng = new System.Windows.Forms.ComboBox();
			this._txtSkill = new System.Windows.Forms.Label();
			this._txtCom = new System.Windows.Forms.Label();
			this._cmbSkill = new System.Windows.Forms.ComboBox();
			this._cmbCom = new System.Windows.Forms.ComboBox();
			this._dataGridView = new System.Windows.Forms.DataGridView();
			this._txtLevel = new System.Windows.Forms.Label();
			this._grpInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// _txtLastName
			// 
			this._txtLastName.AutoSize = true;
			this._txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtLastName.Location = new System.Drawing.Point(6, 55);
			this._txtLastName.Name = "_txtLastName";
			this._txtLastName.Size = new System.Drawing.Size(96, 24);
			this._txtLastName.TabIndex = 0;
			this._txtLastName.Text = "Фамилия:";
			this._txtLastName.Click += new System.EventHandler(this._txtLastName_Click);
			// 
			// _txtEnterLastName
			// 
			this._txtEnterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtEnterLastName.Location = new System.Drawing.Point(103, 55);
			this._txtEnterLastName.Name = "_txtEnterLastName";
			this._txtEnterLastName.Size = new System.Drawing.Size(128, 26);
			this._txtEnterLastName.TabIndex = 1;
			this._txtEnterLastName.TextChanged += new System.EventHandler(this._txtEnterLastName_TextChanged);
			this._txtEnterLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterLastName_KeyPress);
			// 
			// _txtEnterName
			// 
			this._txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtEnterName.Location = new System.Drawing.Point(103, 15);
			this._txtEnterName.Name = "_txtEnterName";
			this._txtEnterName.Size = new System.Drawing.Size(128, 26);
			this._txtEnterName.TabIndex = 3;
			this._txtEnterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterName_KeyPress);
			// 
			// _txtName
			// 
			this._txtName.AutoSize = true;
			this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtName.Location = new System.Drawing.Point(1, 16);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(96, 24);
			this._txtName.TabIndex = 2;
			this._txtName.Text = "         Имя:";
			// 
			// _rdiMale
			// 
			this._rdiMale.AutoSize = true;
			this._rdiMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rdiMale.Location = new System.Drawing.Point(61, 83);
			this._rdiMale.Name = "_rdiMale";
			this._rdiMale.Size = new System.Drawing.Size(84, 20);
			this._rdiMale.TabIndex = 4;
			this._rdiMale.TabStop = true;
			this._rdiMale.Text = "Мужской";
			this._rdiMale.UseVisualStyleBackColor = true;
			// 
			// _txtSex
			// 
			this._txtSex.AutoSize = true;
			this._txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtSex.Location = new System.Drawing.Point(6, 79);
			this._txtSex.Name = "_txtSex";
			this._txtSex.Size = new System.Drawing.Size(49, 24);
			this._txtSex.TabIndex = 5;
			this._txtSex.Text = "Пол:";
			// 
			// _rdiFemale
			// 
			this._rdiFemale.AutoSize = true;
			this._rdiFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._rdiFemale.Location = new System.Drawing.Point(146, 83);
			this._rdiFemale.Name = "_rdiFemale";
			this._rdiFemale.Size = new System.Drawing.Size(85, 20);
			this._rdiFemale.TabIndex = 6;
			this._rdiFemale.TabStop = true;
			this._rdiFemale.Text = "Женский";
			this._rdiFemale.UseVisualStyleBackColor = true;
			// 
			// _grpInfo
			// 
			this._grpInfo.Controls.Add(this._txtLevel);
			this._grpInfo.Controls.Add(this._btnSave);
			this._grpInfo.Controls.Add(this._cmbPosition);
			this._grpInfo.Controls.Add(this._chkMng);
			this._grpInfo.Controls.Add(this._txtPosition);
			this._grpInfo.Controls.Add(this._chkSkill);
			this._grpInfo.Controls.Add(this._chkCom);
			this._grpInfo.Controls.Add(this._txtMng);
			this._grpInfo.Controls.Add(this._cmbMng);
			this._grpInfo.Controls.Add(this._txtSkill);
			this._grpInfo.Controls.Add(this._txtCom);
			this._grpInfo.Controls.Add(this._cmbSkill);
			this._grpInfo.Controls.Add(this._txtLastName);
			this._grpInfo.Controls.Add(this._cmbCom);
			this._grpInfo.Controls.Add(this._rdiFemale);
			this._grpInfo.Controls.Add(this._txtEnterLastName);
			this._grpInfo.Controls.Add(this._txtSex);
			this._grpInfo.Controls.Add(this._txtName);
			this._grpInfo.Controls.Add(this._rdiMale);
			this._grpInfo.Controls.Add(this._txtEnterName);
			this._grpInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this._grpInfo.Location = new System.Drawing.Point(-1, 12);
			this._grpInfo.Name = "_grpInfo";
			this._grpInfo.Size = new System.Drawing.Size(804, 155);
			this._grpInfo.TabIndex = 7;
			this._grpInfo.TabStop = false;
			this._grpInfo.Text = "Анкета";
			this._grpInfo.Enter += new System.EventHandler(this._grpInfo_Enter);
			// 
			// _btnSave
			// 
			this._btnSave.Location = new System.Drawing.Point(716, 114);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(75, 23);
			this._btnSave.TabIndex = 21;
			this._btnSave.Text = "Готово";
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _cmbPosition
			// 
			this._cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbPosition.FormattingEnabled = true;
			this._cmbPosition.Items.AddRange(new object[] {
            "Системный админимтратор",
            "Программист",
            "Менеджер"});
			this._cmbPosition.Location = new System.Drawing.Point(124, 117);
			this._cmbPosition.Name = "_cmbPosition";
			this._cmbPosition.Size = new System.Drawing.Size(176, 21);
			this._cmbPosition.TabIndex = 20;
			this._cmbPosition.SelectedIndexChanged += new System.EventHandler(this._cmbPost_SelectedIndexChanged);
			// 
			// _chkMng
			// 
			this._chkMng.AutoSize = true;
			this._chkMng.Location = new System.Drawing.Point(603, 68);
			this._chkMng.Name = "_chkMng";
			this._chkMng.Size = new System.Drawing.Size(15, 14);
			this._chkMng.TabIndex = 12;
			this._chkMng.UseVisualStyleBackColor = true;
			// 
			// _txtPosition
			// 
			this._txtPosition.AutoSize = true;
			this._txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtPosition.Location = new System.Drawing.Point(6, 114);
			this._txtPosition.Name = "_txtPosition";
			this._txtPosition.Size = new System.Drawing.Size(112, 24);
			this._txtPosition.TabIndex = 19;
			this._txtPosition.Text = "Должность";
			this._txtPosition.Click += new System.EventHandler(this._txtPosition_Click);
			// 
			// _chkSkill
			// 
			this._chkSkill.AutoSize = true;
			this._chkSkill.Location = new System.Drawing.Point(603, 48);
			this._chkSkill.Name = "_chkSkill";
			this._chkSkill.Size = new System.Drawing.Size(15, 14);
			this._chkSkill.TabIndex = 11;
			this._chkSkill.UseVisualStyleBackColor = true;
			// 
			// _chkCom
			// 
			this._chkCom.AutoSize = true;
			this._chkCom.Location = new System.Drawing.Point(603, 24);
			this._chkCom.Name = "_chkCom";
			this._chkCom.Size = new System.Drawing.Size(15, 14);
			this._chkCom.TabIndex = 10;
			this._chkCom.UseVisualStyleBackColor = true;
			this._chkCom.CheckedChanged += new System.EventHandler(this._chkEnglishProficiency_CheckedChanged);
			// 
			// _txtMng
			// 
			this._txtMng.AutoSize = true;
			this._txtMng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtMng.Location = new System.Drawing.Point(237, 68);
			this._txtMng.Name = "_txtMng";
			this._txtMng.Size = new System.Drawing.Size(234, 24);
			this._txtMng.TabIndex = 9;
			this._txtMng.Text = "Управленческие навыки:";
			this._txtMng.Click += new System.EventHandler(this._txtExperience_Click);
			// 
			// _cmbMng
			// 
			this._cmbMng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbMng.FormattingEnabled = true;
			this._cmbMng.Items.AddRange(new object[] {
            "низкий",
            "средний",
            "высокий"});
			this._cmbMng.Location = new System.Drawing.Point(662, 65);
			this._cmbMng.Name = "_cmbMng";
			this._cmbMng.Size = new System.Drawing.Size(87, 21);
			this._cmbMng.TabIndex = 18;
			this._cmbMng.SelectedIndexChanged += new System.EventHandler(this._cmbHowMuchExp_SelectedIndexChanged);
			// 
			// _txtSkill
			// 
			this._txtSkill.AutoSize = true;
			this._txtSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtSkill.Location = new System.Drawing.Point(237, 43);
			this._txtSkill.Name = "_txtSkill";
			this._txtSkill.Size = new System.Drawing.Size(357, 24);
			this._txtSkill.TabIndex = 8;
			this._txtSkill.Text = "Навык работы в офисных программах:";
			// 
			// _txtCom
			// 
			this._txtCom.AutoSize = true;
			this._txtCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._txtCom.Location = new System.Drawing.Point(237, 19);
			this._txtCom.Name = "_txtCom";
			this._txtCom.Size = new System.Drawing.Size(199, 24);
			this._txtCom.TabIndex = 7;
			this._txtCom.Text = "Коммуникативность:";
			this._txtCom.Click += new System.EventHandler(this._txtEnglishProficiency_Click);
			// 
			// _cmbSkill
			// 
			this._cmbSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbSkill.FormattingEnabled = true;
			this._cmbSkill.Items.AddRange(new object[] {
            "низкий",
            "средний",
            "высокий"});
			this._cmbSkill.Location = new System.Drawing.Point(662, 43);
			this._cmbSkill.Name = "_cmbSkill";
			this._cmbSkill.Size = new System.Drawing.Size(87, 21);
			this._cmbSkill.TabIndex = 17;
			// 
			// _cmbCom
			// 
			this._cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbCom.FormattingEnabled = true;
			this._cmbCom.Items.AddRange(new object[] {
            "низкий",
            "средний",
            "высокий"});
			this._cmbCom.Location = new System.Drawing.Point(662, 24);
			this._cmbCom.Name = "_cmbCom";
			this._cmbCom.Size = new System.Drawing.Size(87, 21);
			this._cmbCom.TabIndex = 16;
			this._cmbCom.SelectedIndexChanged += new System.EventHandler(this._cmbLevelEnglish_SelectedIndexChanged);
			// 
			// _dataGridView
			// 
			this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._dataGridView.Location = new System.Drawing.Point(9, 173);
			this._dataGridView.Name = "_dataGridView";
			this._dataGridView.Size = new System.Drawing.Size(781, 215);
			this._dataGridView.TabIndex = 8;
			this._dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridView_CellContentClick);
			// 
			// _txtLevel
			// 
			this._txtLevel.AutoSize = true;
			this._txtLevel.Location = new System.Drawing.Point(662, 11);
			this._txtLevel.Name = "_txtLevel";
			this._txtLevel.Size = new System.Drawing.Size(92, 13);
			this._txtLevel.TabIndex = 22;
			this._txtLevel.Text = "Уровень навыка";
			this._txtLevel.Click += new System.EventHandler(this.label1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this._dataGridView);
			this.Controls.Add(this._grpInfo);
			this.Name = "MainForm";
			this.Text = "Трудоустройство";
			this._grpInfo.ResumeLayout(false);
			this._grpInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label _txtLastName;
		private System.Windows.Forms.TextBox _txtEnterLastName;
		private System.Windows.Forms.TextBox _txtEnterName;
		private System.Windows.Forms.Label _txtName;
		private System.Windows.Forms.RadioButton _rdiMale;
		private System.Windows.Forms.Label _txtSex;
		private System.Windows.Forms.RadioButton _rdiFemale;
		private System.Windows.Forms.GroupBox _grpInfo;
		private System.Windows.Forms.CheckBox _chkCom;
		private System.Windows.Forms.Label _txtMng;
		private System.Windows.Forms.Label _txtSkill;
		private System.Windows.Forms.Label _txtCom;
		private System.Windows.Forms.CheckBox _chkMng;
		private System.Windows.Forms.CheckBox _chkSkill;
		private System.Windows.Forms.ComboBox _cmbMng;
		private System.Windows.Forms.ComboBox _cmbSkill;
		private System.Windows.Forms.ComboBox _cmbCom;
		private System.Windows.Forms.Label _txtPosition;
		private System.Windows.Forms.ComboBox _cmbPosition;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.DataGridView _dataGridView;
		private System.Windows.Forms.Label _txtLevel;
	}
}

