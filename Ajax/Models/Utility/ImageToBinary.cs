using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


using System.Drawing;

using System.Text;
using Microsoft.AspNetCore.Http;

namespace Ajax.Models.Utility
{
    public class ImageToBinary
    {
        //public IFormFile ConvertToImage(byte[] picBinary)
        //{

        //    IFormFile file = null;

        //    if (picBinary == null)
        //    {
        //        return null;
        //    }

        //    using (MemoryStream ms = new MemoryStream(picBinary))
        //    {
        //        IFormFile = Image.FromStream(ms);
        //    }
        //    return image;
        //}

        public byte[] ConvertToByte(IFormFile file)
        {
            if (file == null) { return null; }
            try
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    return ms.ToArray();
                }

            }
            finally
            {
                if (file != null)
                {
                    file=null;
                }
            }
        }

        public void SaveToFile()
        {
            
        }


    }
}
