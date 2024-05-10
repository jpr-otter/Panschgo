using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Panschgo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Board _boardTopLeft;
        private Board _boardTopRight;
        private Board _boardBottomLeft;
        private Board _boardBottomRight;
        private Player _currentPlayer;
        private Player _player1;
        private Player _player2;
        public MainWindow()
        {
            InitializeComponent();

            _player1= new Player("Player 1", Brushes.Red);
            _player2 = new Player("Player 2", Brushes.Green);
            _currentPlayer = _player1;

            _boardTopLeft = new Board(canvasQuadrantTopLeft, 3, 3);
            _boardTopRight = new Board(canvasQuadrantTopRight, 3, 3);
            _boardBottomLeft = new Board(canvasQuadrantBottomLeft, 3, 3);
            _boardBottomRight = new Board(canvasQuadrantBottomRight, 3, 3);
        }

        private void ButtonReset(object sender, RoutedEventArgs e)
        {
            _boardTopLeft.Reset(_currentPlayer, _player1, _player2);
            _boardTopRight.Reset(_currentPlayer, _player1, _player2);
            _boardBottomLeft.Reset(_currentPlayer, _player1, _player2);
            _boardBottomRight.Reset(_currentPlayer, _player1, _player2);
            //_currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;

        }
    }
}
