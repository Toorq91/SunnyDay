namespace StickManApp
{
    internal class Frisbee
    {
        private int _col;
        private int _row;
        private bool _isMovingRight;

        public Frisbee(int col, int row, bool isMovingRight)
        {
            _col = col;
            _row = row;
            _isMovingRight = isMovingRight;
        }

        public void Move()
        {
            if (_isMovingRight)
            {
                _col += 2;
                if (_col > Console.WindowWidth - 1) _isMovingRight = false;
            }
            else
            {
                _col -= 2;
                if (_col < 0) _isMovingRight = true;
            }
        }

        public void SetPosition(int col, int row)
        {
            _col = col;
            _row = row;
        }

        public int GetCol()
        {
            return _col;
        }

        public int GetRow()
        {
            return _row;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_col, _row);
            Console.WriteLine("O");
        }
    }
}