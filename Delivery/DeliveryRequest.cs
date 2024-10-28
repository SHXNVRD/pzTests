namespace Delivery
{
    public class DeliveryRequest
    {
        private DateTime _dateFrom = new(2022,01,01);
        private static int _allSumm;
        private static int _countRequest;

        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if (value != 0)
                    id = value;
                else
                    Console.WriteLine("Значение ID должно быть присвоено!");
            }
        }
        private int summ;
        public int Summ
        {
            get { return summ; }

            set
            {
                if (value >= 0 && value <= 10000)
                    summ = value;
                else
                    Console.WriteLine("Неверноа сумма!");
            }
        }
        public string Adr { get; set; }

        private DateTime requestTime;
        public DateTime RequestTime
        {
            get { return requestTime; }

            set
            { 
                if (value >= _dateFrom && value <= DateTime.Now)
                    requestTime = value; 
            }
        }

        public DeliveryRequest() : this(0)
        { }
        public DeliveryRequest(int ID) : this(ID, 0)
        { }
        public DeliveryRequest(int ID, int Summ) : this(ID, Summ, "Неизвестно")
        { }
        public DeliveryRequest(int ID, int Summ, string Adr) : this(ID, Summ, Adr, "01.01.0001")
        { }
        public DeliveryRequest(int id, int summ, string adr, string date)
        {
            ID = id;
            Summ = summ;
            Adr = adr;
            RequestTime = DateTime.Parse(date);
            _allSumm += Summ;
            ++_countRequest;
        }

        public DeliveryRequest(DeliveryRequest deliveryRequest)
        {
            ID = deliveryRequest.ID;
            Summ = deliveryRequest.Summ;
            Adr = deliveryRequest.Adr;
            RequestTime = deliveryRequest.RequestTime;
            _allSumm += Summ;
            ++_countRequest;
        }
        
        public void GetDeliveryInfo() => Console.WriteLine($"ID: {ID}\nСумма: {Summ}\nВремя заказа: {RequestTime}\nАдресс: {Adr}");
        public static int GetCountRequest() => _countRequest;
        public static int GetAllSumm() => _allSumm;
    }
}