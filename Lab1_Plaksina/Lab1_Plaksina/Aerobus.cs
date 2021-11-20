using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1_Plaksina
{
    public class Aerobus : Airplane
    {
        public Color DopColor { private set; get; }
        public bool Window { private set; get; }
        public bool Floor { private set; get; }

        public Aerobus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool window, bool floor)
            : base(maxSpeed, weight, mainColor, 155, 66)
        {

            DopColor = dopColor;
            Window = window;
            Floor = floor;
        }
        public Aerobus(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Window = Convert.ToBoolean(strs[4]);
                Floor = Convert.ToBoolean(strs[5]);
            }
        }
        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(Color.Black);
            Brush brushdop = new SolidBrush(DopColor);
            if (Window)
            {
                g.DrawEllipse(pen, _startPosX + 113, _startPosY + 40, 10, 10);
                g.FillEllipse(brushdop, _startPosX + 113, _startPosY + 40, 10, 10);

            }
            // 2 этаж
            if (Floor)
            {
                g.DrawRectangle(pen, _startPosX + 37, _startPosY + 15, 90, 18);
                g.FillRectangle(brushdop, _startPosX + 37, _startPosY + 15, 90, 18);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Window}{separator}{Floor}";
        }
    }
}


