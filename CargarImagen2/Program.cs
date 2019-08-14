using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace CargarImagen2
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagen = "C:\\Users\\alumno\\Pictures\\Ace.jpg";

            Image<Bgr, byte> img = new Image<Bgr, byte>(imagen);
        }
    }
}
