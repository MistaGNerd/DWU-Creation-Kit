using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DWCreationKit
{
    public partial class ThemeObjectBrowser : Form
    {
        public Point ParentWindowOffset { get; set; }
        public Size ParentWindowSize { get; set; }
        public Point AnchorOffset { get; set; } = new Point(10, 10);
        public bool Anchored { get; set; } = false;
        public ThemeObjectBrowser()
        {
            InitializeComponent();
        }

        public void UpdateGUI()
        {
            
            Point _location = this.Location ;
            Size _size = this.Size;
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        
    }
}
