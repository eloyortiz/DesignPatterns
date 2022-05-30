namespace Tools
{
    public sealed class Log
    {
        private static Log? _instance = null;
        private string _path;
        private static object _protect = new object(); //objeto genérico para trabajar asíncronamente y protegerlo

        private Log(string path)
        {
            _path = path;
        }

        public static Log GetInstance(string path)
        {
            ///lock protege la instancia para el caso de estar trabajando con hilos, y puede
            ///que se de el caso de que 2 hilos accedan simultaneamente a GetInstance con valor 
            ///de instance a null y en ese caso de generen 2 instancias
            ///aunque se usaría la última; por lo que la primera se perdería.
            ///loc: mientras q está un hilo trabajando con este atributo,
            ///no puede usarlo otro hilo, lo protege.
            lock (_protect)
            {   
                if( _instance == null )
                    _instance = new Log(path);
            }
            return _instance;
        }

        private void Save(string message)
        {

            File.AppendAllText(_path, message + Environment.NewLine);
        }
        public void Info(string message)
        {
            string pattern = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff")} INFO {message}";
            Save(pattern);
        }
        
    }
}