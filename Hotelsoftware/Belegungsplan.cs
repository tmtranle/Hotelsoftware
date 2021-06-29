using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelsoftware
{
    public partial class Belegungsplan : Form
    {
        public Belegungsplan()
        {
            InitializeComponent();
        }

        // 2D-Array 
        //         28.06.  29.06.  30.06.
        // 100       (       )                  1 Nacht
        // 101       (       )
        // 102       (               )          2 Nächte
        // 103


        // ein Tag besteht aus 2 Teilen     => x-Achse
        //  28.06.        29.06
        // |  |  |       |  |  | 
        // Check-In und Check-Out 
        //    (´            )

        // insgesamt 28 Zimmer == 28 Zeilen => y-Achse

    }
}
