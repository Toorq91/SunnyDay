namespace StickManApp
{
    internal class Grass
    {
        private int _col;
        private int _row;
        private bool _isMoving;

        public Grass(int col, int row, bool isMoving)
        {
            _col = col;
            _row = row;
            _isMoving = isMoving;
        }

        public void GrassInTheWind()
        {
            _isMoving = !_isMoving;
        }

        public void Draw()
        {
            var isMoving = _isMoving ? "|,|,|" : ",/,/,/";

            Console.SetCursorPosition(_col, _row);
            Console.WriteLine(isMoving);

        }
    }
}