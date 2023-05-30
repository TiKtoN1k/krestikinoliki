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
using Pobediteli;
using System.IO;
using RegWin;
namespace krestikinoliki;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
/// 

public static class RegWin
{
    private static List<char> getHistory()
    {
        List<char> history = new List<char>();

        history = JsonSerialization.deserialize<List<char>>("history.json");

        return history;
    }


    private static void saveHistory(List<char> history)
    {
        JsonSerialization.serialize(history, "history.json");
    }

    public static void win_x()
    {
        List<char> history = getHistory();
        history.Add('x');
        saveHistory(history);
    }

    public static void win_o()
    {
        List<char> history = getHistory();
        history.Add('o');
        saveHistory(history);
    }

    public static void win_NO()
    {
        List<char> history = getHistory();
        history.Add('_');
        saveHistory(history);
    }
}

public partial class MainWindow : Window
{
    public static int[] krestiki_noliki;
    public static bool xo = true;
    
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        if (File.Exists("history.json"))
        {

        }
        else
        {
            JsonSerialization.serialize(new List<string>(), "history.json");
        }
        StartGame();
    }

    private void start_Click(object sender, RoutedEventArgs e)
    {
        StartGame();
    }

    private void Button1_Click(object sender, RoutedEventArgs e)
    {
        Hod(xo, 0);
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {

            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
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
        int ff = CheckWin.IsFinished(krestiki_noliki);
        if (ff == 1)
        {
            MessageBox.Show("Победа x!"); RegWin.win_x();
        }
        else if (ff == 2)
        {
            MessageBox.Show("Победа o!"); RegWin.win_o();
        }
        else if (ff == 3)
        {
            MessageBox.Show("Ничья!"); RegWin.win_NO();
        }
        else
        {
            Bot();
            return;
        }
        StartGame();
    }

}


