using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfClickerGame
{
    class Program
    {
        static int _count = 0;
        static Label _label;

        [STAThread]

        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var panel = new StackPanel();
            var button = new Button
            {
                Content = "Trykk her!"
            };
            button.Click += ButtonClick;
            _label = new Label
            {
                Content = "Trykk på knappen!"
            };
            panel.Children.Add(button);
            panel.Children.Add(_label);
            window.Content = panel;
            app.Run(window);

        }

        static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count.ToString();
        }

    }
}
