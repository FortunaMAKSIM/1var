using _1var.Data;
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
    public partial class Form2 : Form
    {
        private MyDbContext _dbContext;
        public Form2(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            LoadApplications();
        }

        private void LoadApplications(string faultTypeFilter = null)
        {
            IQueryable<Applica> applicationsQuery = _dbContext.Applicas;

            if (!string.IsNullOrWhiteSpace(faultTypeFilter))
            {
                applicationsQuery = applicationsQuery.Where(a => a.FaultType.Contains(faultTypeFilter));
            }

            var applications = _dbContext.Applicas.ToList();
            dataGridView1.DataSource = applications;
            dataGridView1.Columns["EquipmentDb"].Visible = false;
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заявку для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем выбранную строку
            var selectedRow = dataGridView1.SelectedRows[0];

            // Получаем номер заявки из выбранной строки
            int applicationNumber = (int)selectedRow.Cells["Number"].Value;

            // Загружаем заявку из базы данных
            var application = _dbContext.Applicas.Find(applicationNumber);

            if (application == null)
            {
                MessageBox.Show("Заявка не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Открываем форму редактирования и передаем ей данные заявки
            var editForm = new AddApplicationForm(_dbContext);
            editForm.LoadApplicationData(application);

            // Показываем форму модально
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Обновляем DataGridView после редактирования
                LoadApplications(); // Метод для загрузки данных в DataGridView
            }
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddApplicationForm(_dbContext))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadApplications(); // Обновляем список заявок после добавления
                }
            }
        }

        private void StatBt_Click(object sender, EventArgs e)
        {
            var statisticsForm = new StatisticsForm(_dbContext);
            statisticsForm.ShowDialog();
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            string faultType = SearchTb.Text;

            // Загружаем заявки с фильтром по типу неисправности
            var applications = _dbContext.Applicas
                .Where(a => a.FaultType != null && a.FaultType.Contains(faultType))
                .ToList();

            if (applications.Any())
            {
                MessageBox.Show($"Найдено {applications.Count} записей с типом неисправности: '{faultType}'.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Записи с типом неисправности: '{faultType}' не найдены.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Обновляем DataGridView
            dataGridView1.DataSource = applications;
        }
    }
}
