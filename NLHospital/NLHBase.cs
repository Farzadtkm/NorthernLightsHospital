using System.Windows.Forms;

namespace NLHospital
{
    public class NLHBase : Form
    {
        protected override void Dispose(bool disposing)
        {
            base.Close();
        }
    }
}