class car
    {
        // Перегружаем конструктор         
        public void car()
        {
            Console.WriteLine("No brand selected\n");
        }
        public void car(string Brand)
        {
            Console.WriteLine("Brand: {0}\nNo model selected", Brand);
        }
        public void car(string Brand, string Model)
        {
            Console.WriteLine("Brand: {0} Model: {1}", Brand, Model);
        }
    }
