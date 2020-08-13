using System;
using System.Linq;
using System.Windows;

namespace Polar.Charts
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double k = 7;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = Enumerable.Range(0, 1000)
                .Select(i => 2 * Math.PI * i / 1000.0)
                .Select(t => new
                {
                    Theta = t,
                    R = Math.Cos(k * t),

                    X = Math.Cos(k * t) * Math.Sin(t),
                    Y = Math.Cos(k * t) * Math.Cos(t)
                });
        }
    }
}