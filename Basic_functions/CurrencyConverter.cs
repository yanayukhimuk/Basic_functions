namespace Basic_functions
{
    class CurrencyConverter
    {
        public static double DollarToRub(int dol)
        {
            double rub = (double)dol * 2.5349;
            return rub;
        }

        public static double RubToDollar(int rub)
        {
            double dol = (double)rub * 0.3945;
            return dol;
        }

        public static double EuroToDollar(int euro)
        {
            double dol = (double)euro * 1.1322;
            return dol;
        }

        public static double DollarToEuro (int dol)
        {
            double euro = (double)dol * 0.8832;
            return euro;
        }

        public static double RubToEuro(int rub)
        {
            double euro = (double)rub * 0.3484;
            return euro;
        }

        public static double EuroToRub(int euro)
        {
            double rub = (double)euro * 2.8701;
            return rub;
        }
    }
}
