// CoachingTest.cs
// Run a unit test on the Coaching Class

using System;

class CoachingTest
{
    static void Main()
    {
        Coaching Sport001 = new Coaching("Tennis", 10, "Monday and Wednesday 6-8pm", 150m);
        Sport001.getCoachingInformation();
    }
}