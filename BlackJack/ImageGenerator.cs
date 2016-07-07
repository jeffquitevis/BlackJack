using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class ImageGenerator
    {
     
        private ImageList imageList = new ImageList();
        private const string FileType = ".jpg";
        private int index = 0;
 

        public void GenerateImage(string fileName, ListView listView)
        {
           
            imageList.Images.Add(Image.FromFile(@"c:\users\stephen\desktop\assets\" + fileName + FileType));
            imageList.ImageSize = new Size(150, 150);    
            
            listView.LargeImageList = imageList;
            listView.Items.Add(new ListViewItem() {ImageIndex = index});
            index++;
        }
    }
}
