using System;
using System.Collections.Generic;
using System.Windows.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panschgo
{
    internal class Board
    {
        public Quadrant[] Quadrants { get; set; }
        private Canvas _canvas;
        private int _boardPositionsX;
        private int _boardPositionsY;

        public Board(Canvas canvas, int boardPositionsX, int boardPositionsY)
        {
            _canvas = canvas;
            _boardPositionsX = boardPositionsX;
            _boardPositionsY = boardPositionsY;
            
            //Quadrants = new Quadrant[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    Quadrants[i] = new Quadrant();
            //}
        }
        public void Reset()
        {
            _canvas.Children.Clear();

            for (int i = 0; i < _boardPositionsY; i++)
            {
                for (int j = 0; j < _boardPositionsX; j++)
                {
                    Rectangle rect = new Rectangle();
                    rect.Width = _canvas.ActualWidth / _boardPositionsX - 2.0;
                    rect.Height = _canvas.ActualHeight / _boardPositionsY - 2.0;
                    rect.Fill = Brushes.DarkCyan;
                    _canvas.Children.Add(rect);
                    Canvas.SetLeft(rect, j * _canvas.ActualWidth / _boardPositionsX);
                    Canvas.SetTop(rect, i * _canvas.ActualHeight / _boardPositionsY);
                }
            }

        }
        public string CheckStatus()
        {
            // game check logic
            return "";
        }
        /*
        public static Quadrant GetQuadrant(int index)
        {
            //logic
            
        }
        */
    }
}
