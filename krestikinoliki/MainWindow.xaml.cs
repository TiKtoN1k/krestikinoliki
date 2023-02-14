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


namespace krestikinoliki;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public static int[] krestiki_noliki;
    public static bool xo = true;
    private int IsFinished()
    {
        for (int i = 0; i <= 6; i += 3)
        {
            if (krestiki_noliki[i] == krestiki_noliki[i + 1] && krestiki_noliki[i + 1] == krestiki_noliki[i + 2] && krestiki_noliki[i + 2] != 0)
            {
                return krestiki_noliki[i];
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (krestiki_noliki[i] == krestiki_noliki[i + 3] && krestiki_noliki[i + 3] == krestiki_noliki[i + 6] && krestiki_noliki[i + 6] != 0)
            {
                return krestiki_noliki[i];
            }
        }
        if (krestiki_noliki[0] == krestiki_noliki[4] && krestiki_noliki[4] == krestiki_noliki[8] && krestiki_noliki[8] != 0)
        {
            return krestiki_noliki[0];
        }
        else if (krestiki_noliki[2] == krestiki_noliki[4] && krestiki_noliki[4] == krestiki_noliki[6] && krestiki_noliki[6] != 0)
        {
            return krestiki_noliki[2];
        }
        bool nichya = true;
        for (int i = 0; i < 9; i++)
        {
            if (krestiki_noliki[i] == 0)
            {
                nichya = false;
            }
        }
        if (nichya == true) return 3;
        return 0;
    }
    private void StartGame()
    {
        krestiki_noliki = new int[9];
        for (int i = 0; i < krestiki_noliki.Length; i++)
        {
            krestiki_noliki[i] = 0;
        }
        Button1.Content = "";
        Button1.IsEnabled = true;
        Button2.Content = "";
        Button2.IsEnabled = true;
        Button3.Content = "";
        Button3.IsEnabled = true;
        Button4.Content = "";
        Button4.IsEnabled = true;
        Button5.Content = "";
        Button5.IsEnabled = true;
        Button6.Content = "";
        Button6.IsEnabled = true;
        Button7.Content = "";
        Button7.IsEnabled = true;
        Button8.Content = "";
        Button8.IsEnabled = true;
        Button9.Content = "";
        Button9.IsEnabled = true;
        if (xo == true)
        {
            xo = false;
        }
        else
        {
            xo = true;
        }
        if (xo == true) Bot();
    }
    private void Hod(bool player, int r)
    {
        char krestik;
        if (player == true)
        {
            krestiki_noliki[r] = 2;
            krestik = 'o';
        }
        else
        {
            krestiki_noliki[r] = 1;
            krestik = 'x';
        }
        switch (r)
        {
            case 0:
                Button1.Content = krestik;
                Button1.IsEnabled = false;
                break;
            case 1:
                Button2.Content = krestik;
                Button2.IsEnabled = false;
                break;
            case 2:
                Button3.Content = krestik;
                Button3.IsEnabled = false;
                break;
            case 3:
                Button4.Content = krestik;
                Button4.IsEnabled = false;
                break;
            case 4:
                Button5.Content = krestik;

                Button5.IsEnabled = false;
                break;
            case 5:
                Button6.Content = krestik;
                Button6.IsEnabled = false;
                break;
            case 6:
                Button7.Content = krestik;
                Button7.IsEnabled = false;
                break;
            case 7:
                Button8.Content = krestik;
                Button8.IsEnabled = false;
                break;
            case 8:
                Button9.Content = krestik;
                Button9.IsEnabled = false;
                break;
        }
    }
    private void Bot()
    {
        Random random = new Random();
        int r = random.Next(0, 9);
        if (krestiki_noliki[r] != 0)
        {
            Bot();
        }
        else
        {
            Hod(!xo, r);
        }
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            return;
        }
        StartGame();
    }
    public MainWindow()
    {
        InitializeComponent();
        StartGame();
    }

    private void start_Click(object sender, RoutedEventArgs e)
    {
        StartGame();
    }

    private void Button1_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 0);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button2_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 1);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button3_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 2);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button4_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 3);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button5_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 4);
        int ff = IsFinished();
        if (ff == 1)
        {

            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button6_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 5);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button7_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 6);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button8_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 7);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }
    private void Button9_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 8);
        int ff = IsFinished();
        if (ff == 1)
        {
            MessageBox.Show("Победа x!");
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!");
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья");
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }

}


