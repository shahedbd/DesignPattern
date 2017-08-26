namespace AllDesignPatternExm.Singleton
{
    public sealed class Calculate
    {
        private Calculate()
        {
        }

        private static Calculate instance = null;
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }
                return instance;
            }
        }

        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public double Addition()
        {
            return ValueOne + ValueTwo;
        }

        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }

        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }

        public double Division()
        {
            return ValueOne / ValueTwo;
        }
    }
}
}
