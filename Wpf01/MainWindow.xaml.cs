using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Wpf01
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			WrapPanel wrapPanel = new WrapPanel();
			TextBlock blueTextBlock = new TextBlock();
			blueTextBlock.Text = "Multi";
			blueTextBlock.Foreground = Brushes.Blue;
			wrapPanel.Children.Add(blueTextBlock);
			TextBlock redTextBlock = new TextBlock();
			redTextBlock.Text = "colored";
			redTextBlock.Foreground = Brushes.Red;
			wrapPanel.Children.Add(redTextBlock);
			TextBlock whiteTextBlock = new TextBlock();
			whiteTextBlock.Text = "button";
			whiteTextBlock.Foreground = Brushes.White;
			wrapPanel.Children.Add(whiteTextBlock);

			Button button = new Button();
			button.FontSize = 26;
			button.Content = wrapPanel;

			Grid grid = new Grid();
			this.Content = grid;
			grid.Children.Add(button);
		}
	}
}
