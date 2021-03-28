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

namespace WpfApp5
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Jmeno_LostFocus(object sender, RoutedEventArgs e)
        {
            JmenoError.Content = "";
            if ((sender as TextBox).Text.Length < 1)
            {
                JmenoError.Content = "Jméno je povinna položka";
                return;
            }
            if ((sender as TextBox).Text.Length > 20)
            {
                JmenoError.Content = "Jméno může mít nejvýše 20 znaků";
                return;
            }

        }
        private void Prijmeni_LostFocus(object sender, RoutedEventArgs e)
        {
            PrijmeniError.Content = "";
            if ((sender as TextBox).Text.Length < 1)
            {
                PrijmeniError.Content = "Příjmení je povinna položka";
                return;
            }
            if ((sender as TextBox).Text.Length > 20)
            {
                PrijmeniError.Content = "Příjmení může mít nejvýše 20 znaků";
                return;
            }

        }
        private void Narozeni_LostFocus(object sender, RoutedEventArgs e)
        {
            NarozeniError.Content = "";
            if ((sender as TextBox).Text.Length < 1)
            {
                PrijmeniError.Content = "Rok narození je povinna položka";
                return;
            }
            if ((sender as TextBox).Text.Length != 4)
            {
                NarozeniError.Content = "Rok narození může obsahovat pouze 4 číslice";
                return;
            }
            
        }
        private void Vzdelani_LostFocus(object sender, RoutedEventArgs e)
        {
            VzdelaniError.Content = "";
            if ((sender as ComboBox).SelectedIndex >=0 && (sender as ComboBox).SelectedIndex <=3)
            {
                return;
            }
            else
            {
                VzdelaniError.Content = "Vzdělání je povinna položka";
                return;
            }
        }
        private void Pozice_LostFocus(object sender, RoutedEventArgs e)
        {
            PoziceError.Content = "";
            if ((sender as TextBox).Text.Length < 1)
            {
                PoziceError.Content = "Pracovní pozice je povinna položka";
                return;
            }
            if ((sender as TextBox).Text.Length > 30)
            {
                PoziceError.Content = "Pracovní pozice může mít nejvýše 30 znaků";
                return;
            }
        }
        private void Plat_LostFocus(object sender, RoutedEventArgs e)
        {
            PlatError.Content = "";
            if ((sender as TextBox).Text.Length < 1)
            {
                PlatError.Content = "Plat v hrubém je povinna položka";
                return;
            }
            if ((sender as TextBox).Text.Length > 6)
            {
                PlatError.Content = "Plat v hrubém může mít nejvýše 6 číslic";
                return;
            }
        }

        private void Hotovo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Jmeno.Text} {Prijmeni.Text}, {Rok_narozeni.Text}, {(Vzdelani.SelectedItem as ComboBoxItem).Content}, {Pracovni_pozice.Text}, {Plat.Text}Kč");
            Zaměstnanec obj = new Zaměstnanec();
            obj.Name = Jmeno.Text;
            obj.Surname = Prijmeni.Text;
            obj.Date = Convert.ToInt32(Rok_narozeni.Text);
            obj.Education = Vzdelani.Text;
            obj.Job = Pracovni_pozice.Text;
            obj.Salary = Convert.ToInt32(Plat.Text);

        }
    }
    class Osoba
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private int date;
        public int Date
        {
            get { return date; }
            set { date = value; }
        }

    }
    class Zaměstnanec:Osoba
    {
        private string education;
        public string Education
        {
            get { return education; }
            set { education = value; }
        }
        private string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
