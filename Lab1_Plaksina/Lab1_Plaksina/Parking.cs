﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1_Plaksina
{
    public class Parking<T> where T : class, ITransport
    {

        private readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 300;

        private readonly int _placeSizeHeight = 80;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static int operator +(Parking<T> p, T aer)
        {
            int width = p.pictureWidth / p._placeSizeWidth;

            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = aer;
                    aer.SetPosition(i % width * p._placeSizeWidth + 5, i / width * p._placeSizeHeight + 5, p.pictureWidth, p.pictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if ((index < p._places.Length) && (index >= 0))
            {
                T aer = p._places[index];
                p._places[index] = null;
                return aer;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {

                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}

