using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Desktop.Controls
{
    public partial class DetailsCard : UserControl
    {
        public DetailsCard()
        {
            InitializeComponent();

        }

        public void AddRow(string label, string value)
        {
            // New row number
            int rowIndex = tblRows.RowCount;

            //Adding new row
            tblRows.RowCount++;
            tblRows.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Label Name
            var lblKey = new Label
            {
                Text = label,
                ForeColor = Color.FromArgb(161, 161, 170),
                AutoSize = true,
                Margin = new Padding(0, 6, 12, 6),
                Anchor = AnchorStyles.Left
            };

            // Label Value
            var lblValue = new Label
            {
                Text = string.IsNullOrWhiteSpace(value) ? "-" : value,
                ForeColor = Color.FromArgb(249, 250, 251),
                AutoSize = true,
                Margin = new Padding(0, 6, 0, 6),
                Anchor = AnchorStyles.Left
            };

            // Add to table
            tblRows.Controls.Add(lblKey, 0, rowIndex);
            tblRows.Controls.Add(lblValue, 1, rowIndex);
        }

        // Add Several Rows at once
        public void AddRows(params(string Label, string Value)[] rows)
        {
            foreach(var row in rows)
            {
                AddRow(row.Label, row.Value);
            }
        }

        public string CardTitle
        {
            get => lblCardTitle.Text;
            set => lblCardTitle.Text = value;
        }
    }
}
