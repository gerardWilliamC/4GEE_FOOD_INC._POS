using System.Windows.Forms;

namespace Cahapay_IT202WM_LabExam2_Midterm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pOSCashierToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void jEEPOSIncToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Example2 newMDIChild = new Example2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void jeePOSIncToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            POS_Admin posAdmin = new POS_Admin();
            posAdmin.MdiParent = this;
            posAdmin.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Example4 newMDIChild = new Example4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Example3 newMDIChild = new Example3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void jeeOrderingToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OrderingPOS_Admin orderAdmin = new OrderingPOS_Admin();
            orderAdmin.MdiParent = this;
            orderAdmin.Show();
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            User_AccountFrm newMDIchild = new User_AccountFrm();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void exampleCMSToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void jeePOSIncToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            jEEPOSIncToolStripMenuItem_Click(e, e);
        }

        private void btnPOS_Click(object sender, System.EventArgs e)
        {
            jEEPOSIncToolStripMenuItem_Click(e, e);
        }

        private void windowToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
