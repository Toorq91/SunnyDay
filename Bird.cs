namespace StickManApp
{
    internal class Bird
    {
        private int _col;
        private int _row;
        private bool _wingsUp;

        public Bird(int col, int row, bool wingsUp)
        {
            _col = col;
            _row = row;
            _wingsUp = wingsUp;
        }

        public void SwapBirdWings()
        {
            _wingsUp = !_wingsUp;
        }

        public void Draw()
        {
            var wingsUp = _wingsUp ? 'M' : 'W';

            Console.SetCursorPosition(_col, _row);
            Console.WriteLine(wingsUp);
        }
    }
}