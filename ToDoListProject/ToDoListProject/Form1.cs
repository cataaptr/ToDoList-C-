using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using ToDoListProject.DataAccess;
using LiveCharts.Charts;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Xml.Serialization;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//cale fisiere: string filePath = @"C:\Users\HP\Desktop\1051_Apetroaei_Emanuela-Catalina\ToDoListProject\ToDoListProject\Questions.txt"; //salvare pe Desktop

namespace ToDoListProject
{
    public partial class Form1 : MaterialForm
    {
        List<Category> categoryList = new List<Category>();
        List<Task> taskList = new List<Task>();
        public Form1()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            string theme = ComboBoxTheme.Text;
            bool darkMode = SwitchMode.Checked;
            openFileForReadTheme(ref theme, ref darkMode);
            updateThemeAndMode(darkMode);
            updateTheme2(theme);

            materialSlider3.ValueMax = 24;

            ComboBoxTheme.Items.Add("Blue");
            ComboBoxTheme.Items.Add("Red");
            ComboBoxTheme.Items.Add("Green");
            ComboBoxTheme.Items.Add("Purple");
            ComboBoxLanguage.Items.Add("English");

            List<Tuple<DateTime, int[]>> questionDataList = new List<Tuple<DateTime, int[]>>();
            questionDataList = ReadQuestionData();
            // DisplayQuestionData(questionDataList);

            createChart(questionDataList);


            UserData userData = new UserData();
            userData.openFileForReadUserData(ref userData);
            tbName.Text = userData.FullName;
            tbEmail.Text = userData.Email;
            tbPhone.Text = userData.PhoneNumber;



            categoryList.Add(new Category(1, "Personal"));
            categoryList.Add(new Category(2, "Work"));
            categoryList.Add(new Category(3, "Study"));


            PopulateCategoryComboBox();
            InitializeTaskList();
            PopulateListView();
            PopulateIncompleteTasksListView();
            PopulateCompleteTasksListView();
            PopulateAllCategoriesListBox();


        }
        private void InitializeTaskList()
        {
            taskList = new List<Task>
             {
                new Task(categoryList[0], "Go to the gym", DateTime.Now, DateTime.Now.AddHours(2), false),
                 new Task(categoryList[1], "Finish project report", DateTime.Now, DateTime.Now.AddHours(5), true),
                 new Task(categoryList[2], "Read chapter 4", DateTime.Now, DateTime.Now.AddHours(3), false),
                 new Task(categoryList[0], "Grocery shopping", DateTime.Now, DateTime.Now.AddHours(1), true),
                  new Task(categoryList[1], "Team meeting", DateTime.Now, DateTime.Now.AddHours(2), false),
                new Task(categoryList[2], "Complete online course", DateTime.Now, DateTime.Now.AddHours(6), true),
                new Task(categoryList[0], "Morning jog", DateTime.Now, DateTime.Now.AddHours(1), false),
                new Task(categoryList[1], "Client call", DateTime.Now, DateTime.Now.AddHours(1), true),
                new Task(categoryList[2], "Write essay", DateTime.Now, DateTime.Now.AddHours(4), false),
                new Task(categoryList[0], "Clean the house", DateTime.Now, DateTime.Now.AddHours(3), true),
                new Task(categoryList[1], "Prepare presentation", DateTime.Now, DateTime.Now.AddHours(4), false),
                new Task(categoryList[2], "Study for exam", DateTime.Now, DateTime.Now.AddHours(5), true),
                new Task(categoryList[0], "Call mom", DateTime.Now, DateTime.Now.AddHours(1), false),
                new Task(categoryList[1], "Update website", DateTime.Now, DateTime.Now.AddHours(2), true),
                new Task(categoryList[2], "Group project meeting", DateTime.Now, DateTime.Now.AddHours(3), false),
                new Task(categoryList[0], "Cook dinner", DateTime.Now, DateTime.Now.AddHours(2), true),
                new Task(categoryList[1], "Email boss", DateTime.Now, DateTime.Now.AddHours(1), false),
                new Task(categoryList[2], "Attend webinar", DateTime.Now, DateTime.Now.AddHours(3), true),
                 new Task(categoryList[0], "Walk the dog", DateTime.Now, DateTime.Now.AddHours(1), false),
                new Task(categoryList[1], "Review budget", DateTime.Now, DateTime.Now.AddHours(2), true)
                };
        }
        private void PopulateAllCategoriesListBox()
        {

            listBox1.Items.Clear();

            foreach (var c in categoryList)
            {
                MaterialListBoxItem item = new MaterialListBoxItem(c.CategoryName);
                listBox1.Items.Add(item);
            }
        }
        public void insertTask(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            DialogResult result = form3.ShowDialog();


            if (result == DialogResult.OK)
            {

                Task task = new Task();
                task.Description = form3.materialTextBox1.Text;
                string categoryName = form3.materialTextBox2.Text;
                Category selectedCategory = categoryList.FirstOrDefault(cat => cat.CategoryName == categoryName);

                if (selectedCategory != null)
                {
                    task.Category = selectedCategory;
                }
                else
                {
                    MessageBox.Show("Categoria introdusa nu exista. Va rugam sa introduceti o categorie valida.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                task.StartDate = DateTime.Parse(form3.dateTimePicker1.Value.ToShortDateString());
                task.EndDate = DateTime.Parse(form3.dateTimePicker2.Value.ToShortDateString());
                task.Done = form3.GetSliderValue() == 1;


                taskList.Add(task);


                ListViewItem itm = new ListViewItem(task.Description);
                itm.SubItems.Add(task.Category.CategoryName);
                itm.SubItems.Add(task.StartDate.ToShortDateString());
                itm.SubItems.Add(task.EndDate.ToShortDateString());
                itm.SubItems.Add(task.Done ? "Yes" : "No");



                MessageBox.Show("Task introdus cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);


                PopulateListView();
                PopulateIncompleteTasksListView();
                PopulateCompleteTasksListView();


            }
            else
            {

                MessageBox.Show("Forma s-a ]nchis cu CANCEL.", "Anulare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void PopulateCategoryComboBox()
        {
            cbCategory2.Items.Clear();

            cbCategory2.Items.Add("All");

            foreach (var category in categoryList)
            {
                cbCategory2.Items.Add(category.CategoryName);
            }

            if (cbCategory2.Items.Count > 0)
            {
                cbCategory2.SelectedIndex = 0;
            }
        }

        private void PopulateListView()
        {

            list1.Items.Clear();

            if (taskList == null || taskList.Count == 0)
            {
                return;
            }

            string selectedCategory = cbCategory2.SelectedItem.ToString();

            List<Task> filteredTaskList;
            if (selectedCategory == "All")
            {
                filteredTaskList = taskList;
            }
            else
            {
                filteredTaskList = taskList.Where(task => task.Category.CategoryName == selectedCategory).ToList();
            }

            foreach (var task in filteredTaskList)
            {
                ListViewItem itm = new ListViewItem(task.Description);
                itm.SubItems.Add(task.Category.CategoryName);
                itm.SubItems.Add(task.StartDate.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(task.EndDate.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(task.Done ? "Yes" : "No");
                list1.Items.Add(itm);
            }
        }
        private void PopulateIncompleteTasksListView()
        {
            list2.Items.Clear();

            List<Task> incompleteTasks = taskList.Where(task => !task.Done).ToList();

            foreach (var task in incompleteTasks)
            {
                ListViewItem itm = new ListViewItem(task.Description);
                itm.SubItems.Add(task.Category.CategoryName);
                itm.SubItems.Add(task.StartDate.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(task.EndDate.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(task.Done ? "Yes" : "No");
                list2.Items.Add(itm);
            }
        }
        private void PopulateCompleteTasksListView()
        {
            list3.Items.Clear();

            List<Task> completeTasks = taskList.Where(task => task.Done).ToList();

            foreach (var task in completeTasks)
            {
                ListViewItem itm = new ListViewItem(task.Description);
                itm.SubItems.Add(task.Category.CategoryName);
                itm.SubItems.Add(task.StartDate.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(task.EndDate.ToString("yyyy-MM-dd"));
                itm.SubItems.Add(task.Done ? "Yes" : "No");
                list3.Items.Add(itm);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void materialSlider1_Click(object sender, EventArgs e)
        {

        }

        private void materialSlider2_Click(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            updateTheme(SwitchMode.Checked);
        }


        private void updateTheme(bool isDarkMode)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            if (isDarkMode)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                updateThemeFile(1);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                updateThemeFile(0);
            }
        }
        private void updateThemeFile(int value)
        {
            try
            {
                string[] lines = File.ReadAllLines("C:\\Users\\HP\\Desktop\\1051_Apetroaei_Emanuela-Catalina\\ToDoListProject\\ToDoListProject\\UpdateT.txt");

                if (lines.Length > 0)
                {
                    lines[0] = value.ToString();
                }

                File.WriteAllLines("C:\\Users\\HP\\Desktop\\1051_Apetroaei_Emanuela-Catalina\\ToDoListProject\\ToDoListProject\\UpdateT.txt", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea in fisierul de configurare: " + ex.Message);
            }
        }

        private void updateTheme2(string theme)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            switch (theme)
            {
                case "Red":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.BlueGrey500, Accent.Red100, TextShade.WHITE);
                    updateTheme2File("Red");
                    break;
                case "Blue":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.BlueGrey500, Accent.Blue100, TextShade.WHITE);
                    updateTheme2File("Blue");
                    break;
                case "Green":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);
                    updateTheme2File("Green");
                    break;
                case "Purple":
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple100, TextShade.WHITE);
                    updateTheme2File("Purple");
                    break;
            }
        }
        private void updateTheme2File(string theme)
        {
            try
            {
                string filePath = @"C:\Users\HP\Desktop\1051_Apetroaei_Emanuela-Catalina\ToDoListProject\ToDoListProject\UpdateT.txt";

                if (File.Exists(filePath))
                {
                    List<string> lines = new List<string>();

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }

                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (lines[i].Trim() == theme)
                        {
                            lines[i] = theme;
                        }
                    }


                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        foreach (string line in lines)
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la scrierea in fisierul de configurare pentru tema: " + ex.Message);
            }
        }


        private void openFileForReadTheme(ref string t, ref bool d)
        {


            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\HP\\Desktop\\1051_Apetroaei_Emanuela-Catalina\\ToDoListProject\\ToDoListProject\\UpdateT.txt"))
                {
                    string copie = sr.ReadLine();
                    if (copie == "0")
                        d = false;
                    else
                        d = true;
                    t = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea din fisierul de configurare: " + ex.Message);
            }
        }

        private void updateThemeAndMode(bool isDarkMode)
        {
            updateTheme(isDarkMode);
            SwitchMode.Checked = isDarkMode;
        }
        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTheme2(ComboBoxTheme.Text);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            
            insertTask(sender, e);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            UpdateFileQuestions(materialSlider1.Value, materialSlider2.Value, materialSlider3.Value, materialSlider4.Value, materialSlider5.Value);
        }

        private void materialSlider5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateFileQuestions(int v1, int v2, int v3, int v4, int v5)
        {
            try
            {
                string filePath = @"C:\Users\HP\Desktop\1051_Apetroaei_Emanuela-Catalina\ToDoListProject\ToDoListProject\Questions.txt";

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                string data = $"{currentDate},{v1},{v2},{v3},{v4},{v5}";

                List<string> lines = new List<string>();
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                }

                bool found = false;
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].StartsWith(currentDate))
                    {
                        lines[i] = data;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    lines.Add(data);
                }

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizarea fisierului cu intrebari: " + ex.Message);
            }
        }

        private List<Tuple<DateTime, int[]>> ReadQuestionData()
        {
            List<Tuple<DateTime, int[]>> questionDataList = new List<Tuple<DateTime, int[]>>();

            try
            {
                string filePath = @"C:\Users\HP\Desktop\1051_Apetroaei_Emanuela-Catalina\ToDoListProject\ToDoListProject\Questions.txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');


                            DateTime date = DateTime.Parse(parts[0]);


                            int[] questionData = new int[parts.Length - 1];
                            for (int i = 1; i < parts.Length; i++)
                            {
                                questionData[i - 1] = int.Parse(parts[i]);
                            }


                            questionDataList.Add(new Tuple<DateTime, int[]>(date, questionData));
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Fișierul cu întrebari nu exista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea fisierului cu intrebari: " + ex.Message);
            }

            return questionDataList;
        }

        void createChart(List<Tuple<DateTime, int[]>> questionDataList)
        {
            chart1.Series.Clear();

            string[] columnNames = { "Feeling", "Task Completed", "Hours Allocated", "Stress", "Satisfaction" };

            foreach (string columnName in columnNames)
            {
                Series series = new Series(columnName)
                {
                    ChartType = SeriesChartType.Column
                };

                foreach (var entry in questionDataList)
                {
                    DateTime date = entry.Item1;
                    int[] values = entry.Item2;


                    int columnIndex = Array.IndexOf(columnNames, columnName);


                    if (values.Length > columnIndex)
                    {
                        double value = values[columnIndex];
                        series.Points.AddXY(date.ToShortDateString(), value);
                    }
                    else
                    {

                        series.Points.AddXY(date.ToShortDateString(), 0);
                    }
                }


                chart1.Series.Add(series);
            }
            DateTime firstDate = questionDataList.Min(entry => entry.Item1);
            DateTime lastDate = questionDataList.Max(entry => entry.Item1);

            string xAxisTitle = $"Date ({firstDate.ToShortDateString()} - {lastDate.ToShortDateString()})";
            chart1.ChartAreas[0].AxisX.Title = xAxisTitle;

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            chart1.ChartAreas[0].AxisY.Title = "Medium Value";
        }



        private void DisplayQuestionData(List<Tuple<DateTime, int[]>> questionDataList)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var tuple in questionDataList)
                {
                    stringBuilder.Append("Date: ");
                    stringBuilder.Append(tuple.Item1.ToString("yyyy-MM-dd"));
                    stringBuilder.Append(", Values: ");
                    int[] questionData = tuple.Item2;
                    for (int i = 0; i < questionData.Length; i++)
                    {
                        stringBuilder.Append(questionData[i]);
                        if (i < questionData.Length - 1)
                        {
                            stringBuilder.Append(", ");
                        }
                    }
                    stringBuilder.AppendLine();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afișarea datelor: " + ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDocument_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);


            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = pd;


            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Tuple<DateTime, int[]>> questionDataList = ReadQuestionData();

            Graphics g = e.Graphics;
            String str;
            float y = 0;


            str = "Date       Task Completed";
            g.DrawString(str, Font, Brushes.Black, 10, y += 26);


            foreach (var entry in questionDataList)
            {
                DateTime date = entry.Item1;
                int[] values = entry.Item2;

                str = $"{date.ToShortDateString()}   {(values.Length >= 3 ? values[2].ToString() : "N/A")}";

                g.DrawString(str, Font, Brushes.Black, 10, y += 13);
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Form2 machetaDataPersonale = new Form2();
            DialogResult r = machetaDataPersonale.ShowDialog();
            if (r == DialogResult.OK)
            {
                UserData userData = new UserData
                {
                    FullName = machetaDataPersonale.tbN.Text,
                    Email = machetaDataPersonale.tbE.Text,
                    PhoneNumber = machetaDataPersonale.tbP.Text
                };

                
                Console.WriteLine($"FullName: {userData.FullName}");
                Console.WriteLine($"Email: {userData.Email}");
                Console.WriteLine($"PhoneNumber: {userData.PhoneNumber}");

                string userDataString = $"{userData.FullName},{userData.Email},{userData.PhoneNumber}";

                try
                {
                    string filePath = "C:\\Users\\HP\\Desktop\\1051_Apetroaei_Emanuela-Catalina\\ToDoListProject\\ToDoListProject\\PersonalData.txt";
                    File.WriteAllText(filePath, userDataString);
                    MessageBox.Show("Datele au fost salvate cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    if (File.Exists(filePath))
                    {
                        string content = File.ReadAllText(filePath);
                        Console.WriteLine($"Conținutul fișierului: {content}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare la salvarea datelor în fișier: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tbName.Text = userData.FullName;
                tbEmail.Text = userData.Email;
                tbPhone.Text = userData.PhoneNumber;

               
                Console.WriteLine($"tbName: {tbName.Text}");
                Console.WriteLine($"tbEmail: {tbEmail.Text}");
                Console.WriteLine($"tbPhone: {tbPhone.Text}");
            }
            else
            {
                Console.WriteLine("Dialogul a fost anulat.");
            }
        }

        private void cbCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            addCategpry();
        }
        private void addCategpry()
        {
            string newCategory = tbCat2.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCategory))
            {
                MessageBox.Show("Introduceti o categorie valida!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            bool categoryExists = categoryList.Any(category => category.CategoryName == newCategory);


            if (!categoryExists)
            {
                categoryList.Add(new Category(categoryList.Count + 1, newCategory));
                MessageBox.Show("Categoria a fost adaugata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateCategoryComboBox();
                PopulateAllCategoriesListBox();
            }
            else
            {
                MessageBox.Show("Categoria exista deja!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteToolStripMenuItem_Click(sender, e);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list1.SelectedItems.Count > 0)
            {
                ListViewItem itm = list1.SelectedItems[0];
                int pozitie = itm.Index;


                list1.Items.RemoveAt(pozitie);
                list1.Refresh();

                PopulateCompleteTasksListView();
                PopulateIncompleteTasksListView();


                Task task = taskList[pozitie];
                taskList.RemoveAt(pozitie);

            }
            else
            {
                MessageBox.Show("Selectati linia din listView pe care doriti sa o stergeti.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile(sender, e);
        }

        private void saveFile(object sender, EventArgs e)
        //am facut cu fisier Xml, deoarece nu imi recunostea : BinaryFormatter bf = new BinaryFormatter(); si spunea ca este nesigur
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
                using (FileStream fileStream = new FileStream("task.xml", FileMode.Create))
                {
                    serializer.Serialize(fileStream, taskList);
                }
                MessageBox.Show($"Au fost salvate {taskList.Count} inregistrari", "Salvare Reusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A aparut o eroare la salvarea fisierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void openFromFile(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Task>));
                using (FileStream fileStream = new FileStream("task.xml", FileMode.Open))
                {
                    taskList = (List<Task>)serializer.Deserialize(fileStream);
                }
                MessageBox.Show($"Au fost încarcate {taskList.Count} inregistrari", "Incarcare Reusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A aparut o eroare la încarcarea fisierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFromFile(sender, e);
        }
    }
}
