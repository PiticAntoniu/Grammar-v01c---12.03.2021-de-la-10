using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grammar_v01c
{
    public partial class EditForm : Form
    {
        Grammar g = new Grammar();
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Grammar g)
        {
            this.g = g;
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // g.LoadFromFile(Properties.Resources.DefaultGrammarLocation);
            startSymbolTextBox.Text = g.StartSymbol.ToString();
            terminalsTextBox.Text = Helper.CharListToString(g.Terminals);
            nonterminalsTextBox.Text = Helper.CharListToString(g.Nonterminals);

            productionsDataGridView.DataSource = g.ProductionList;
        }
    }
}
