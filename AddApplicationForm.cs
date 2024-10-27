using _1var.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1var
{
    public partial class AddApplicationForm : Form
    {
        private readonly MyDbContext _dbContext;
        private int? _applicationNumber;
        public AddApplicationForm(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        // Метод для заполнения формы данными существующей заявки
        public void LoadApplicationData(Applica application)
        {
            _applicationNumber = application.Number; // Запоминаем номер заявки
            ClientTb.Text = application.ClientId.ToString();
            PriorTb.Text = application.Priority;
            TypeTb.Text = application.FaultType;
            DescTb.Text = application.ProblemDesc;

            // Установите значения Minimum и Maximum для PriceNum
            PriceNum.Minimum = 0; // Установите минимальное значение
            PriceNum.Maximum = 100000; // Установите максимальное значение (или любое другое разумное значение)

            // Убедитесь, что ExecCost не null и в пределах допустимого диапазона
            decimal execCostValue = (decimal)application.ExecCost.GetValueOrDefault(0); // Получаем значение или 0 по умолчанию
            PriceNum.Value = execCostValue < PriceNum.Minimum ? PriceNum.Minimum :
                             execCostValue > PriceNum.Maximum ? PriceNum.Maximum :
                             execCostValue;
        }

        public void SaveBt_Click(object sender, EventArgs e)
        {
            try
            {
                Applica application;

                // Если редактируем, загружаем существующую заявку
                if (_applicationNumber.HasValue)
                {
                    application = _dbContext.Applicas.Find(_applicationNumber.Value);

                    if (application == null)
                    {
                        MessageBox.Show("Заявка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    var maxNumber = _dbContext.Applicas.Max(a => (int?)a.Number) ?? 0; // ?? 0 означает, что если таблица пуста, то maxNumber будет 0

                    application = new Applica
                    {
                        Number = maxNumber + 1, // Увеличиваем на 1
                        EquipmentDb = 0 // Или какое-то другое значение, если требуется
                    };

                    // Проверяем, существует ли уже запись с таким номером
                    if (_dbContext.Applicas.Any(a => a.Number == application.Number))
                    {
                        throw new DbUpdateException($"Запись с номером {application.Number} уже существует.");
                    }

                    _dbContext.Applicas.Add(application); // Добавляем в контекст
                }

                // Обновляем поля заявки
                application.ClientId = int.Parse(ClientTb.Text);
                application.Priority = PriorTb.Text;
                application.FaultType = TypeTb.Text;
                application.ProblemDesc = DescTb.Text;
                application.ExecCost = (int)PriceNum.Value;

                _dbContext.SaveChanges();

                MessageBox.Show("Заявка сохранена! Номер заявки: " + application.Number, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.InnerException?.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неизвестная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetApplicationData(int clientId, string priority, string faultType, string problemDesc, decimal execCost)
        {
            ClientTb.Text = clientId.ToString();
            PriorTb.Text = priority;
            TypeTb.Text = faultType;
            DescTb.Text = problemDesc;

            // Убедитесь, что execCost находится в пределах установленного диапазона
            PriceNum.Minimum = 0; // Установите минимальное значение
            PriceNum.Maximum = 10000; // Установите максимальное значение
            PriceNum.Value = execCost; // Установка значения
        }

    }
}
