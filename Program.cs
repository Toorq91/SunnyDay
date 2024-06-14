using StickManApp;
using System.Runtime.InteropServices;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.CursorVisible = false;

        var stickManA = new StickMan(5, 10, true, false, true);
        var stickManB = new StickMan(8, 16, false, true, false);
        var stickManC = new StickMan(20, 13, true, true, true);
        var frisbee = new Frisbee(stickManC.GetHandPosition().col, stickManC.GetHandPosition().row, true);

        var bird1 = new Bird(83, 5, true);
        var bird2 = new Bird(90, 5, true);
        var bird3 = new Bird(85, 4, false);
        var bird4 = new Bird(88, 4, false);
        var bird5 = new Bird(87, 3, true);
        var sun = new Sun(98, 1, true);

        var cloud1 = new Cloud(20, 2, true);
        var cloud2 = new Cloud(50, 4, true);
        var cloud3 = new Cloud(70, 3, false);

        var grass1 = new Grass(90, 14, true);
        var grass2 = new Grass(93, 13, false);
        var grass3 = new Grass(96, 14, true);


        while (true)
        {
            Console.Clear();
            sun.Draw();
            grass1.Draw();
            grass2.Draw();
            grass3.Draw();
            cloud1.Draw();
            cloud2.Draw();
            cloud3.Draw();
            bird1.Draw();
            bird2.Draw();
            bird3.Draw();
            bird4.Draw();
            bird5.Draw();
            stickManA.Draw();
            stickManB.Draw();
            stickManC.Draw();
            frisbee.Draw();

            Thread.Sleep(300);
            grass1.GrassInTheWind();
            grass2.GrassInTheWind();
            grass3.GrassInTheWind();

            sun.SwapSunBeam();
            bird1.SwapBirdWings();
            bird2.SwapBirdWings();
            bird3.SwapBirdWings();
            bird4.SwapBirdWings();
            bird5.SwapBirdWings();
            stickManA.Swap();
            stickManA.Move();
            stickManB.Swap();
            stickManB.Move();
            stickManC.Swap();
            stickManC.Move();
            cloud1.Move();
            cloud2.Move();
            cloud3.Move();

            if (!stickManC.IsThrowing())
            {
                stickManC.PrepareToThrow(frisbee);
            }

            stickManC.AnimateThrow();
            frisbee.Move();


        }
    }
}
