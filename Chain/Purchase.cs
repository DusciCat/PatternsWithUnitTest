namespace Chain
{
    /// <summary>
    /// Класс детали запроса
    /// </summary>
    public class Purchase
    {
        int _number;
        double _amount;
        string _purpose;

        // Конструктор
        public Purchase(int number, double amount, string purpose)
        {
            _number = number;
            _amount = amount;
            _purpose = purpose;
        }

        // Получаем и задаем номер покупки
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Получаем и задаем цену покупки
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        // Получаем и задаем цель покупки
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}