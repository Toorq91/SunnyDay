namespace StickManApp
{
    internal class StickMan
    {
        private int _col;
        private int _row;
        private bool _leftArmIsUp;
        private bool _rightArmIsUp;
        private bool _isMovingRight;
        private Frisbee _frisbee;
        private bool _isThrowing;
        private int _throwStep;
        private int _frisbeeOriginalCol;
        private int _frisbeeOriginalRow;

        public StickMan(int col, int row, bool leftArmIsUp, bool rightArmIsUp, bool isMovingRight)
        {
            _col = col;
            _row = row;
            _leftArmIsUp = leftArmIsUp;
            _rightArmIsUp = rightArmIsUp;
            _isMovingRight = isMovingRight;
            _isThrowing = false;
            _throwStep = 0;
        }

        public void Swap()
        {
            _leftArmIsUp = !_leftArmIsUp;
            _rightArmIsUp = !_rightArmIsUp;
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
            var leftArmUp = _leftArmIsUp ? '\\' : ' ';
            var rightArmUp = _rightArmIsUp ? '/' : ' ';
            var leftArmDown = !_leftArmIsUp ? '/' : ' ';
            var rightArmDown = !_rightArmIsUp ? '\\' : ' ';

            Console.SetCursorPosition(_col, _row);
            Console.WriteLine($"{leftArmUp}O{rightArmUp}");
            Console.SetCursorPosition(_col, _row + 1);
            Console.WriteLine($"{leftArmDown}|{rightArmDown}");
            Console.SetCursorPosition(_col, _row + 2);
            Console.WriteLine("/ \\");
        }

        public void PrepareToThrow(Frisbee frisbee)
        {
            _frisbee = frisbee;
            _isThrowing = true;
            _throwStep = 0;
            var handPosition = GetHandPosition();
            _frisbee.SetPosition(handPosition.col, handPosition.row);
            _frisbeeOriginalCol = handPosition.col;
            _frisbeeOriginalRow = handPosition.row;
        }

        public void AnimateThrow()
        {
            if (_isThrowing && _frisbee != null)
            {
                switch (_throwStep)
                {
                    case 0:
                        _leftArmIsUp = true;
                        _rightArmIsUp = false;
                        _frisbee.SetPosition(_col + 1, _row);
                        break;
                    case 1:
                        _leftArmIsUp = false;
                        _rightArmIsUp = true;
                        _frisbee.SetPosition(_col + 2, _row - 1);
                        break;
                    case 2:
                        _leftArmIsUp = true;
                        _rightArmIsUp = false;
                        _frisbee.SetPosition(_col + 3, _row - 2);
                        break;
                    case 3:
                        _leftArmIsUp = false;
                        _rightArmIsUp = true;
                        _frisbee.SetPosition(_col + 4, _row - 3);
                        _frisbee.Move();
                        _isThrowing = false;
                        break;
                    case 4:
                        _frisbee.Move();
                        if (_frisbee.GetCol() > Console.WindowWidth || _frisbee.GetRow() < 0)
                        {
                            _frisbee.SetPosition(_frisbeeOriginalCol, _frisbeeOriginalRow);
                            _isThrowing = false;
                        }
                        break;
                }

                _throwStep++;
            }
        }

        public bool IsThrowing()
        {
            return _isThrowing;
        }

        public (int col, int row) GetHandPosition()
        {
            return (_col + 1, _row);
        }
    }
}