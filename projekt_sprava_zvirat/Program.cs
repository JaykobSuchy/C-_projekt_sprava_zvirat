using projekt_sprava_zvirat.Logika;

namespace projekt_sprava_zvirat
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var vybehLogika = new VybehLogika();
            var zvireLogika = new ZvireLogika();
            var zzaznamLogika = new ZZaznamLogika();
            Application.Run(new Form1(vybehLogika, zvireLogika, zzaznamLogika));
        }
    }
}