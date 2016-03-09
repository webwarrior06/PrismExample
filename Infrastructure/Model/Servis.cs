using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infrastructure.Model
{
    public class Servis : IServis
    {
        public void ShowMessage()
        {
            MessageBox.Show("Servisten çağırıldı");
        }
    }
}
