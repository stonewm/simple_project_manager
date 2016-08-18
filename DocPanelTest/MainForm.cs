using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DocPanelTest
{
    public partial class MainForm : Form
    {
        private int docIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenNewDocument()
        {
            var docForm = new DocForm();
            docForm.Show(this.dockPanel1);

            docIndex++;
            docForm.Text = "Untitiled document " + docIndex;
            docForm.DockTo(this.dockPanel1, DockStyle.None);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 启动显示navigation form, navigation form
            // 位于docpanel中，放置在左边
            var navForm = new NavigationForm();
            navForm.Show(this.dockPanel1, DockState.DockLeft);            

            OpenNewDocument();
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewDocument();
        }
    }
}
