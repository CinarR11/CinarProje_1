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
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        public string KategoriName { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>(); 

    }
}
