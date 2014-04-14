using System.Collections;

namespace GetPrimeFactors
{
    public class CalculatePrimeFactors
    {
        private ArrayList _primeNumbers;
        public ArrayList PrimeNumbers 
        { 
            get { return _primeNumbers; } 
        }

        public CalculatePrimeFactors()
        {
            _primeNumbers = new ArrayList();
        }

        public void Calculate(int n)
        {
            _primeNumbers.Clear();
            Calculate(n, n - 1);
        }

        private void Calculate(int n, int m) 
	    { 
		    if(isPrimeNumber(n)) 
		    { 
			    _primeNumbers.Add(n); 
		    } 
		    else if(n % m == 0) 
		    {
                Calculate(m, m - 1);
                Calculate(n / m, (n / m) - 1); 
		    } 
		    else 
		    {
                Calculate(n, m - 1); 
		    } 
	    }

        private bool isPrimeNumber(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0) 
                    return false;
            }

            return true;
        }
    }
}
