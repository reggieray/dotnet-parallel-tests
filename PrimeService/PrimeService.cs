namespace Prime.Services
{
    public class PrimeService
    {
        public async Task<bool> IsPrime(int candidate)
        {
            await Task.Delay(5000);

            if (candidate == 1)
            {
                return false;
            }

            if (candidate == 2)
            {
                return true;
            }

            if (candidate == 3)
            {
                return true;
            }

            throw new NotImplementedException("Not fully implemented.");
        }
    }
}
