using WeifenLuo.WinFormsUI.Docking;

namespace SimpleProjectManager
{
    public partial class NavigationForm : DockContent
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void NavigationForm_Load(object sender, System.EventArgs e)
        {
            this.Text = "Navigation";
        }
    }
}
