namespace StickManApp
{
    internal class Cloud
    {
        private int _col;
        private int _row;
        private bool _isMovingRight;

        public Cloud(int col, int row, bool isMovingRight)
        {
            _col = col;
            _row = row;
            _isMovingRight = isMovingRight;
        }

        public void Move()
        {
            if (_isMovingRight)
            {
                _col++;
                if (_col > Console.WindowWidth - 10) _col = 0;
            }
            else
            {
                _col--;
                if (_col < 0) _col = Console.WindowWidth - 10;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(_col, _row);
            Console.WriteLine("  .--.  ");
            Console.SetCursorPosition(_col, _row + 1);
            Console.WriteLine(".-(  ).");
            Console.SetCursorPosition(_col, _row + 2);
            Console.WriteLine("(__._)_)");
        }
    }
}