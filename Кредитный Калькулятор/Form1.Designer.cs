namespace Кредитный_Калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spinEdit_zarplata = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_percent = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_cymma = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_mecPlatezh = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.spinEdit_mecPereplata = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_periodPereplata = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_mecProcent = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_periodProcentPereplata = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_cpok = new DevExpress.XtraEditors.SpinEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.spinEdit_procentCZarplati = new DevExpress.XtraEditors.SpinEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.spinEdit_octatokZarplati = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_zarplata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_percent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cymma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_mecPlatezh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_mecPereplata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_periodPereplata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_mecProcent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_periodProcentPereplata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cpok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_procentCZarplati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_octatokZarplati.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Годовой процент кредита:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма кредита:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Средняя з\\п в месяц:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ежемесяный платёж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Процент переплаты за месяц:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Процент переплаты за весь период:";
            // 
            // spinEdit_zarplata
            // 
            this.spinEdit_zarplata.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_zarplata.EditValue = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.spinEdit_zarplata.Location = new System.Drawing.Point(250, 34);
            this.spinEdit_zarplata.Name = "spinEdit_zarplata";
            this.spinEdit_zarplata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_zarplata.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEdit_zarplata.Properties.Mask.EditMask = "c0";
            this.spinEdit_zarplata.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_zarplata.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_zarplata.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_zarplata.TabIndex = 6;
            this.spinEdit_zarplata.EditValueChanged += new System.EventHandler(this.EventChangeValue);
            // 
            // spinEdit_percent
            // 
            this.spinEdit_percent.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_percent.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEdit_percent.Location = new System.Drawing.Point(250, 78);
            this.spinEdit_percent.Name = "spinEdit_percent";
            this.spinEdit_percent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_percent.Properties.Mask.EditMask = "P";
            this.spinEdit_percent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_percent.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_percent.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_percent.TabIndex = 7;
            this.spinEdit_percent.EditValueChanged += new System.EventHandler(this.EventChangeValue);
            // 
            // spinEdit_cymma
            // 
            this.spinEdit_cymma.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_cymma.EditValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spinEdit_cymma.Location = new System.Drawing.Point(250, 120);
            this.spinEdit_cymma.Name = "spinEdit_cymma";
            this.spinEdit_cymma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_cymma.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEdit_cymma.Properties.Mask.EditMask = "c0";
            this.spinEdit_cymma.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_cymma.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_cymma.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_cymma.TabIndex = 8;
            this.spinEdit_cymma.EditValueChanged += new System.EventHandler(this.EventChangeValue);
            // 
            // spinEdit_mecPlatezh
            // 
            this.spinEdit_mecPlatezh.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_mecPlatezh.EditValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_mecPlatezh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spinEdit_mecPlatezh.Location = new System.Drawing.Point(250, 194);
            this.spinEdit_mecPlatezh.Name = "spinEdit_mecPlatezh";
            this.spinEdit_mecPlatezh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_mecPlatezh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.spinEdit_mecPlatezh.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEdit_mecPlatezh.Properties.Mask.EditMask = "c0";
            this.spinEdit_mecPlatezh.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_mecPlatezh.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_mecPlatezh.Properties.ReadOnly = true;
            this.spinEdit_mecPlatezh.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_mecPlatezh.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сумма переплаты за месяц:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Сумма переплаты за весь период:";
            // 
            // spinEdit_mecPereplata
            // 
            this.spinEdit_mecPereplata.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_mecPereplata.EditValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_mecPereplata.Location = new System.Drawing.Point(250, 282);
            this.spinEdit_mecPereplata.Name = "spinEdit_mecPereplata";
            this.spinEdit_mecPereplata.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_mecPereplata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.spinEdit_mecPereplata.Properties.Mask.EditMask = "c0";
            this.spinEdit_mecPereplata.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_mecPereplata.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_mecPereplata.Properties.ReadOnly = true;
            this.spinEdit_mecPereplata.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_mecPereplata.TabIndex = 14;
            // 
            // spinEdit_periodPereplata
            // 
            this.spinEdit_periodPereplata.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_periodPereplata.EditValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_periodPereplata.Location = new System.Drawing.Point(250, 368);
            this.spinEdit_periodPereplata.Name = "spinEdit_periodPereplata";
            this.spinEdit_periodPereplata.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_periodPereplata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.spinEdit_periodPereplata.Properties.Mask.EditMask = "c0";
            this.spinEdit_periodPereplata.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_periodPereplata.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_periodPereplata.Properties.ReadOnly = true;
            this.spinEdit_periodPereplata.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_periodPereplata.TabIndex = 15;
            // 
            // spinEdit_mecProcent
            // 
            this.spinEdit_mecProcent.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_mecProcent.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEdit_mecProcent.Location = new System.Drawing.Point(250, 238);
            this.spinEdit_mecProcent.Name = "spinEdit_mecProcent";
            this.spinEdit_mecProcent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_mecProcent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.spinEdit_mecProcent.Properties.Mask.EditMask = "P";
            this.spinEdit_mecProcent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_mecProcent.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_mecProcent.Properties.ReadOnly = true;
            this.spinEdit_mecProcent.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_mecProcent.TabIndex = 16;
            // 
            // spinEdit_periodProcentPereplata
            // 
            this.spinEdit_periodProcentPereplata.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_periodProcentPereplata.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEdit_periodProcentPereplata.Location = new System.Drawing.Point(250, 325);
            this.spinEdit_periodProcentPereplata.Name = "spinEdit_periodProcentPereplata";
            this.spinEdit_periodProcentPereplata.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_periodProcentPereplata.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.spinEdit_periodProcentPereplata.Properties.Mask.EditMask = "P";
            this.spinEdit_periodProcentPereplata.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_periodProcentPereplata.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit_periodProcentPereplata.Properties.ReadOnly = true;
            this.spinEdit_periodProcentPereplata.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_periodProcentPereplata.TabIndex = 17;
            // 
            // spinEdit_cpok
            // 
            this.spinEdit_cpok.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_cpok.EditValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spinEdit_cpok.Location = new System.Drawing.Point(250, 155);
            this.spinEdit_cpok.Name = "spinEdit_cpok";
            this.spinEdit_cpok.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_cpok.Properties.Mask.EditMask = "d";
            this.spinEdit_cpok.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_cpok.Properties.MaxValue = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.spinEdit_cpok.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_cpok.TabIndex = 19;
            this.spinEdit_cpok.EditValueChanged += new System.EventHandler(this.EventChangeValue);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Период кредита (месяц):";
            // 
            // spinEdit_procentCZarplati
            // 
            this.spinEdit_procentCZarplati.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_procentCZarplati.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit_procentCZarplati.Location = new System.Drawing.Point(250, 440);
            this.spinEdit_procentCZarplati.Name = "spinEdit_procentCZarplati";
            this.spinEdit_procentCZarplati.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_procentCZarplati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.spinEdit_procentCZarplati.Properties.Mask.EditMask = "P";
            this.spinEdit_procentCZarplati.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_procentCZarplati.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_procentCZarplati.Properties.ReadOnly = true;
            this.spinEdit_procentCZarplati.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_procentCZarplati.TabIndex = 20;
            this.spinEdit_procentCZarplati.ValueChanged += new System.EventHandler(this.spinEdit_procentCZarplati_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Процент с зарплаты:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Остаток с зарплаты:";
            // 
            // spinEdit_octatokZarplati
            // 
            this.spinEdit_octatokZarplati.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.spinEdit_octatokZarplati.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit_octatokZarplati.Location = new System.Drawing.Point(250, 405);
            this.spinEdit_octatokZarplati.Name = "spinEdit_octatokZarplati";
            this.spinEdit_octatokZarplati.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.spinEdit_octatokZarplati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.spinEdit_octatokZarplati.Properties.Mask.EditMask = "c0";
            this.spinEdit_octatokZarplati.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEdit_octatokZarplati.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spinEdit_octatokZarplati.Properties.ReadOnly = true;
            this.spinEdit_octatokZarplati.Size = new System.Drawing.Size(100, 20);
            this.spinEdit_octatokZarplati.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 481);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.spinEdit_octatokZarplati);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spinEdit_procentCZarplati);
            this.Controls.Add(this.spinEdit_cpok);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spinEdit_periodProcentPereplata);
            this.Controls.Add(this.spinEdit_mecProcent);
            this.Controls.Add(this.spinEdit_periodPereplata);
            this.Controls.Add(this.spinEdit_mecPereplata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spinEdit_mecPlatezh);
            this.Controls.Add(this.spinEdit_cymma);
            this.Controls.Add(this.spinEdit_percent);
            this.Controls.Add(this.spinEdit_zarplata);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 520);
            this.MinimumSize = new System.Drawing.Size(420, 520);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитный Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_zarplata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_percent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cymma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_mecPlatezh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_mecPereplata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_periodPereplata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_mecProcent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_periodProcentPereplata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_cpok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_procentCZarplati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_octatokZarplati.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spinEdit_zarplata;
        private DevExpress.XtraEditors.SpinEdit spinEdit_percent;
        private DevExpress.XtraEditors.SpinEdit spinEdit_cymma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SpinEdit spinEdit_mecPereplata;
        private DevExpress.XtraEditors.SpinEdit spinEdit_periodPereplata;
        private DevExpress.XtraEditors.SpinEdit spinEdit_mecProcent;
        private DevExpress.XtraEditors.SpinEdit spinEdit_periodProcentPereplata;
        private DevExpress.XtraEditors.SpinEdit spinEdit_cpok;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SpinEdit spinEdit_mecPlatezh;
        private DevExpress.XtraEditors.SpinEdit spinEdit_procentCZarplati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SpinEdit spinEdit_octatokZarplati;
    }
}

