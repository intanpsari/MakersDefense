using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoM
{
    class Point
    {
       // dideklarasi diluar fungsi karna supaya bisa dipake lagi difungsi lain di bawahnya
        public readonly int X;
        public readonly int Y;

        //ciri khas point , sehingga menurunkan ke turunannya (karena ini constructor paling awal)
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int distanceTo(int x, int y)
        {
            var selisihX = X - x; //X kapital itu yang atas, x kecil itu ga ada hubunganya sma x kecil yg di atas tapi x dan y fungsi distanceTo ini
            var selisihY = Y - y;

            var selisihXkuadrat = selisihX * selisihX;
            var selisihYkuadrat = Math.Pow(selisihY, 2);

            var jumlah = selisihXkuadrat + selisihYkuadrat;
            var akar = Math.Sqrt(jumlah);

            return (int)akar;

        }

        //overloading digunakan ketika isi fungsi sama tapi parameternya beda
        public int distanceTo(Point point)
        {
            return distanceTo(point.X, point.Y);

        }

    }
}
