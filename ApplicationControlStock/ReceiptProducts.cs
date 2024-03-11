
using System.Windows.Forms;

namespace ApplicationControlStock
{
    public partial class ReceiptProducts : Form
    {
        public ReceiptProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows.Add(new string[] {"1", "Pen", "3"});
            

        }
    }
}
