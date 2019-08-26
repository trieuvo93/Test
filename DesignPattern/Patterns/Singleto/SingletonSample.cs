namespace Singleto
{
    public class SingletonSample
    {
        private static SingletonSample _instance;
        private int _number;

        private SingletonSample() { }
        public static SingletonSample GetInstance()
        {
            return _instance ?? (_instance = new SingletonSample());
        }

        public void IncreaseNumber()
        {
            _number++;
        }

        public int GetNumber()
        {
            return _number;
        }
    }
}
