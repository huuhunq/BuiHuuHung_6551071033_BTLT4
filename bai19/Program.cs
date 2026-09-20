namespace ThanhTrangThai
{
    internal static class Program
    {
        static void Log(string s)
        {
            string path = Path.Combine(Path.GetTempPath(), "b19trace.txt");
            File.AppendAllText(path, s + Environment.NewLine);
        }

        [STAThread]
        static void Main()
        {
            try
            {
                Log("1 start");
                ApplicationConfiguration.Initialize();
                Log("2 init");
                frmTrangThai f = new frmTrangThai();
                Log("3 ctor ok");
                Application.Run(f);
                Log("4 run tra ve binh thuong");
            }
            catch (Exception ex)
            {
                Log("LOI >>> " + ex.GetType().FullName + ": " + ex.Message);
                Log(ex.StackTrace);
            }
        }
    }
}
