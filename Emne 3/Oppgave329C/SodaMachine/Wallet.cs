
namespace SodaMachine
{
    internal class Wallet
    {
        int _coin1;
        int _coin5;
        int _coin10;
        int _coin20;

        public Wallet(int c1, int c5, int c10, int c20)
        {
            _coin1 = c1;
            _coin5 = c5;
            _coin10 = c10;
            _coin20 = c20;

        }

        public int GetAmount()
        {
            return _coin1+_coin5+_coin10+_coin20;
        }
    }
}
