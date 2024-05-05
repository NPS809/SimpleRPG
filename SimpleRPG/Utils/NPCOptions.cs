namespace SimpleRPG.Utils
{
    internal class NPCOptions
    {
        internal int mood = Mood.Neutral;
        internal bool gender = Gender.Male;

        internal int money = 0;
        
        internal bool can_dialog = true;
    }
     
    internal static class Mood
    {
        internal const int Beatiful = 3;
        internal const int Good = 2;
        internal const int NotBad = 1;
        internal const int Neutral = 0;
        internal const int NotGood = -1;
        internal const int Bad = -2;
        internal const int Terrible = -3;
    }

    internal static class Gender
    {
        internal const bool Male = true;
        internal const bool Female = false;
    }

}
