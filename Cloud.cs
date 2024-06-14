namespace StickManApp
{
    internal class Cloud
    {
        private int _col;
        private int _row;
        private bool _isMovingRight;
        private bool _isReversed;

        public Cloud(int col, int row, bool isMovingRight)
        {
            _col = col;
            _row = row;
            _isMovingRight = isMovingRight;
            _isReversed = false;
        }

        public void Move()
        {
            if (_isMovingRight)
            {
                _col++;
                if (_col > Console.WindowWidth - 10)
                {
                    _isMovingRight = false;
                    _isReversed = !_isReversed;
                }
            }
            else
            {
                _col--;
                if (_col < 1)
                {
                    _isMovingRight = true;
                    _isReversed = !_isReversed;
                }
            }
        }

        public void Draw()
        {
            if (_isReversed)
            {
                Console.SetCursorPosition(_col, _row);
                Console.WriteLine(" .---.  ");
                Console.SetCursorPosition(_col, _row + 1);
                Console.WriteLine(".(   )--.");
                Console.SetCursorPosition(_col, _row + 2);
                Console.WriteLine("(__(___._)");
            }
            else
            {
            Console.SetCursorPosition(_col, _row);
            Console.WriteLine("   .---.  ");
            Console.SetCursorPosition(_col, _row + 1);
            Console.WriteLine(".--(   ).");
            Console.SetCursorPosition(_col, _row + 2);
            Console.WriteLine("(_.___)__)");
            }
        }

        public static class StringExtensions
        {
            public static string Reverse(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
        }
    }
}