using System;
class Breathing : Parent {
    public Breathing(int duration) : base(duration) {
        Duration = duration;
    }

    public void StartActivity() {
        //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        for (int i = 0; i < Duration; i++) {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Pause for 3 seconds
        }
    }
}