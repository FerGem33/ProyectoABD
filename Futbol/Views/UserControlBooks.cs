using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Futbol.Views
{
    public partial class UserControlBooks : UserControl
    {
        private TableLayoutPanel tableLayout;
        private FlowLayoutPanel buttonPanel;
        private DataGridView grid;
        private TextBox txtTitle, txtAuthor, txtYear;
        private Button btnAdd, btnEdit, btnDelete, btnSave, btnCancel;

        public UserControlBooks()
        {
            InitializeComponent();
            BuildLayout();
        }

        private void BuildLayout()
        {
            // Basic style
            this.Dock = DockStyle.Fill;
            this.Padding = new Padding(15);
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Font = new Font("Segoe UI", 10);

            // ========== INPUT FORM ==========
            tableLayout = new TableLayoutPanel()
            {
                ColumnCount = 2,
                RowCount = 3,
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(0, 0, 0, 10),
            };
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Inputs
            txtTitle = CreateTextbox();
            txtAuthor = CreateTextbox();
            txtYear = CreateTextbox();

            tableLayout.Controls.Add(new Label() { Text = "Title:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            tableLayout.Controls.Add(txtTitle, 1, 0);

            tableLayout.Controls.Add(new Label() { Text = "Author:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 1);
            tableLayout.Controls.Add(txtAuthor, 1, 1);

            tableLayout.Controls.Add(new Label() { Text = "Year:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 2);
            tableLayout.Controls.Add(txtYear, 1, 2);

            // ========== BUTTONS ==========
            buttonPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Top,
                FlowDirection = FlowDirection.RightToLeft,
                AutoSize = true,
                Padding = new Padding(0, 0, 0, 10)
            };

            btnAdd = CreateButton("Add");
            btnEdit = CreateButton("Edit");
            btnDelete = CreateButton("Delete");
            btnSave = CreateButton("Save");
            btnCancel = CreateButton("Cancel");

            buttonPanel.Controls.AddRange(new Control[] { btnCancel, btnSave, btnDelete, btnEdit, btnAdd });

            // ========== DATA GRID ==========
            grid = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                ReadOnly = true,
                AllowUserToAddRows = false
            };

            // Add fake data for now
            LoadFakeData();

            // ========== COMPOSE LAYOUT ==========
            var mainPanel = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1,
            };
            mainPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // inputs
            mainPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));  // buttons
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));  // grid

            mainPanel.Controls.Add(tableLayout, 0, 0);
            mainPanel.Controls.Add(buttonPanel, 0, 1);
            mainPanel.Controls.Add(grid, 0, 2);

            this.Controls.Add(mainPanel);
        }

        private TextBox CreateTextbox()
        {
            return new TextBox()
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                Margin = new Padding(3, 3, 3, 10)
            };
        }

        private Button CreateButton(string text)
        {
            return new Button()
            {
                Text = text,
                AutoSize = true,
                Padding = new Padding(10, 5, 10, 5),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightSteelBlue,
                Margin = new Padding(5)
            };
        }

        private void LoadFakeData()
        {
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Author");
            dt.Columns.Add("Year");

            dt.Rows.Add(1, "The Hobbit", "J.R.R. Tolkien", "1937");
            dt.Rows.Add(2, "1984", "George Orwell", "1949");
            dt.Rows.Add(3, "Dune", "Frank Herbert", "1965");

            grid.DataSource = dt;
        }
    }
}
