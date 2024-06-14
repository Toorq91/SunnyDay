namespace StickManApp
{
    internal class Sun
    {
        private int _col;
        private int _row;
        private bool _sunBeam;

        public Sun(int col, int row, bool sunBeam)
        {
            _col = col;
            _row = row;
            _sunBeam = sunBeam;
        }

        public void SwapSunBeam()
        {
            _sunBeam = !_sunBeam;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_col, _row);
            Console.WriteLine("\\ | /");
            Console.SetCursorPosition(_col, _row + 1);
            Console.WriteLine($"- O -");
            Console.SetCursorPosition(_col, _row + 2);
            Console.WriteLine($"/ | \\");

            if (_sunBeam)
            {
                Console.SetCursorPosition(_col, _row);
                Console.WriteLine("/ | \\");
                Console.SetCursorPosition(_col, _row + 1);
                Console.WriteLine($"\\ O /");
                Console.SetCursorPosition(_col, _row + 2);
                Console.WriteLine($"\\ | /");
            }
        }
    }
}