using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmoCare
{
    public partial class Form1 : Form
    {
        private string sciezkaPliku = "historia_nastrojow.txt";  // Ścieżka do pliku z historią
        public Form1()
        {
            InitializeComponent();
            InicjalizujWykres();
        }
        private void InicjalizujWykres()
        {
            // Ustawienia wykresu
            chartNastroj.Series.Clear();
            Series seria = new Series("Nastroje");
            seria.ChartType = SeriesChartType.Line;
            chartNastroj.Series.Add(seria);
            chartNastroj.ChartAreas[0].AxisX.Title = "Data";
            chartNastroj.ChartAreas[0].AxisY.Title = "Nastrój";

            // Dostosowanie osi X do wyświetlania dat
            chartNastroj.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Format daty
            chartNastroj.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days; // Ustawienie interwału na dni
            chartNastroj.ChartAreas[0].AxisX.Interval = 1; // Wyświetlanie co jeden dzień
            chartNastroj.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Pochylenie etykiet na osi X dla lepszej widoczności
        }

        private void WczytajHistorieDoWykresu()
        {
            // Wyczyść poprzednie dane z wykresu
            chartNastroj.Series["Nastroje"].Points.Clear();

            if (File.Exists(sciezkaPliku))
            {
                // Odczytaj wszystkie linie z pliku
                var linie = File.ReadAllLines(sciezkaPliku);

                foreach (var linia in linie)
                {
                    // Zakładamy, że format to: "yyyy-MM-dd - Nastrój: nastrój"
                    var czesci = linia.Split(new[] { " - " }, StringSplitOptions.None);

                    if (czesci.Length >= 2)
                    {
                        DateTime data;
                        if (DateTime.TryParse(czesci[0], out data)) // Użycie DateTime.TryParse
                        {
                            int ocenaNastroju = AnalizujOceneNastroju(czesci[1]);

                            // Debugowanie: Wyświetl datę i ocenę nastroju
                            Console.WriteLine($"Data: {data.ToShortDateString()}, Nastrój: {ocenaNastroju}");

                            // Dodanie punktu do wykresu
                            chartNastroj.Series["Nastroje"].Points.AddXY(data, ocenaNastroju);
                        }
                        else
                        {
                            MessageBox.Show($"Niepoprawny format daty w linii: {linia}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak zapisanej historii do wizualizacji.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnalizuj_Click(object sender, EventArgs e)
        {
            string nastroj = txtNastroj.Text.ToLower();  // Pobranie tekstu i zamiana na małe litery
            string wynikAnalizy = AnalizujNastroj(nastroj);  // Wywołanie funkcji analizy nastroju i ustawienie wyniku w etykiecie
            lblWynik.Text = wynikAnalizy;
            // Zapisz wynik analizy do pliku z datą
            ZapiszNastrojDoPliku(nastroj, wynikAnalizy);
        }

        private string AnalizujNastroj(string nastroj)
        {
            if (nastroj.Contains("szczęśliwy") || nastroj.Contains("radość") || nastroj.Contains("spokojny"))
            {
                return "Cieszę się, że masz dobry dzień! Może warto zrobić coś kreatywnego?";
            }
            else if (nastroj.Contains("smutny") || nastroj.Contains("zmęczony") || nastroj.Contains("zły"))
            {
                return "Wygląda na to, że nie czujesz się najlepiej. Proponuję krótką medytację lub technikę oddechową.";
            }
            else
            {
                return "Nie jestem pewien, jak się czujesz. Pamiętaj, każdy dzień jest ważny!";
            }
        }

        private void btnCytat_Click(object sender, EventArgs e)
        {
            lblCytat.Text = WyslijCytat();  // Wywołanie funkcji generującej cytat
        }

        // Funkcja losująca cytat motywacyjny
        private string WyslijCytat()
        {
            string[] cytaty = {
                "Nie poddawaj się, wszystko co najlepsze dopiero przed Tobą.",
                "Pamiętaj, że każdy dzień to nowa szansa.",
                "Najważniejsze jest, aby nigdy nie przestawać próbować.",
                "Każdy problem ma swoje rozwiązanie. Działaj!"
            };

            Random rand = new Random();
            int index = rand.Next(cytaty.Length);  // Wylosowanie indeksu cytatu
            return cytaty[index];  // Zwrócenie cytatu
        }
        // Funkcja do zapisu nastroju i analizy do pliku tekstowego
        private void ZapiszNastrojDoPliku(string nastroj, string wynikAnalizy)
        {
            try
            {
                // Utwórz nową linię tekstu z datą, nastrojem i wynikiem analizy
                string nowaLinia = DateTime.Now.ToString("yyyy-MM-dd HH:mm") + " - Nastrój: " + nastroj + " - Wynik: " + wynikAnalizy;

                // Zapisz linię do pliku, dodając ją na końcu
                File.AppendAllText(sciezkaPliku, nowaLinia + Environment.NewLine);

                MessageBox.Show("Nastrój został zapisany w historii.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania nastroju: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {

            // Sprawdź, czy plik historii istnieje
            if (File.Exists(sciezkaPliku))
            {
                // Odczytaj zawartość pliku
                string historia = File.ReadAllText(sciezkaPliku);

                // Wyświetl zawartość w oknie dialogowym lub w nowym oknie
                MessageBox.Show(historia, "Historia nastrojów", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Brak zapisanej historii.", "Historia nastrojów", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Funkcja, która przetwarza opis nastroju na ocenę liczbową
        private int AnalizujOceneNastroju(string nastroj)
        {
            // Debugowanie: Wyświetl nastroj
            Console.WriteLine($"Analizowany nastrój: {nastroj}");

            // Reszta kodu
            if (nastroj.Contains("bardzo szczęśliwy") || nastroj.Contains("zachwycony") || nastroj.Contains("euforia"))
            {
                return 2; // bardzo pozytywny nastrój
            }
            else if (nastroj.Contains("szczęśliwy") || nastroj.Contains("radość") || nastroj.Contains("spokojny"))
            {
                return 1; // pozytywny nastrój
            }
            else if (nastroj.Contains("neutralny") || nastroj.Contains("normalny"))
            {
                return 0; // neutralny nastrój
            }
            else if (nastroj.Contains("smutny") || nastroj.Contains("zmęczony") || nastroj.Contains("zły"))
            {
                return -1; // negatywny nastrój
            }
            else if (nastroj.Contains("bardzo smutny") || nastroj.Contains("przygnębiony") || nastroj.Contains("depresja"))
            {
                return -2; // bardzo negatywny nastrój
            }
            else
            {
                return 0; // domyślnie neutralny nastrój
            }
        }

        private void btnWczytajWykres_Click(object sender, EventArgs e)
        {
            WczytajHistorieDoWykresu();
        }
    }
}
