namespace mayıntarlası
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Uygulama yapılandırmasını başlat.
            ApplicationConfiguration.Initialize();

            // Form2 ile başlatıyoruz.
            Application.Run(new Form2());
        }
    }
}
