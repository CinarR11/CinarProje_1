using amp12b_1083_stp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amp12b_1083_stp
{
    public class Musteriler
    {
        [Key]
        public int Id { get; set; }

        public string MusteriAdi { get; set; }

        public virtual ICollection<Musteriler> Musteriler { get; set; } = new HashSet<Musteriler>();
    }
}
