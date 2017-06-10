using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Кредитный_Калькулятор
{
    public partial class Form1 : Form
    {
        /* Название и обозначение:
         * _zarplata - 
         * _percent - 
         * _cymma - 
         * _cpok - 
         * _mecPlatezh - 
         * _mecProcent - 
         * _mecPereplata - 
         * _periodProcentPereplata - 
         * _periodPereplata - 
         * _procentCZarplati - 
        */
        private double _zarplata, _percent, _cymma, _cpok, _mecPlatezh, 
            _mecProcent, _mecPereplata, _periodProcentPereplata,
            _periodPereplata, _procentCZarplati, _octatokZarplati;

        public Form1()
        {
            InitializeComponent();
            EventChangeValue(this, EventArgs.Empty);
        }

        private void Loading()
        {
            _zarplata = (double)spinEdit_zarplata.Value;
            _percent = (double)spinEdit_percent.Value;
            _cymma = (double)spinEdit_cymma.Value;
            _cpok = (double)spinEdit_cpok.Value;
        }

        private void Calc()
        {
            _periodPereplata = _cymma * (_percent / 100);
            _mecPereplata = _periodPereplata / _cpok;
            _mecPlatezh = (_cymma / _cpok) + _mecPereplata;
            _procentCZarplati = _mecPlatezh * 100 / _zarplata;
            _mecProcent = _percent/12;
            _periodProcentPereplata = _mecProcent*_cpok;
            _octatokZarplati = _zarplata - _mecPlatezh;
            Update(); // Записываем данные
        }

        private new void Update()
        {
            try
            {
                // Проверяем что значение положительное и больше 0
                if (_periodPereplata > 1) spinEdit_periodPereplata.Value = (decimal)_periodPereplata;
                if (_mecPereplata > 1) spinEdit_mecPereplata.Value = (decimal)_mecPereplata;
                if (_mecPlatezh > 1) spinEdit_mecPlatezh.Value = (decimal)_mecPlatezh;
                if (_procentCZarplati > 1) spinEdit_procentCZarplati.Value = (decimal)_procentCZarplati;
                if (_mecProcent > 1) spinEdit_mecProcent.Value = (decimal)_mecProcent;
                if (_periodProcentPereplata > 1)
                    spinEdit_periodProcentPereplata.Value = (decimal) _periodProcentPereplata;
                spinEdit_octatokZarplati.Value = (decimal)_octatokZarplati;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EventChangeValue(object sender, EventArgs e)
        {
            Loading(); // Прогружаем изминения
            Calc(); // Просчитываем проценты
            Update(); // Выводим значения
        }

        private void spinEdit_procentCZarplati_ValueChanged(object sender, EventArgs e) // Смена цвета для процента с з\п
        {
            if (spinEdit_procentCZarplati.Value <= 10)
            {
                spinEdit_procentCZarplati.ForeColor = Color.Green;
            }
            else if (spinEdit_procentCZarplati.Value > 10 && spinEdit_procentCZarplati.Value <= 25)
            {
                spinEdit_procentCZarplati.ForeColor = Color.Goldenrod;
            }
            else
            {
                spinEdit_procentCZarplati.ForeColor = Color.Red;
            }
        }

    }
}
