namespace GoodMorning
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Dictionary that holds seven key/value pairs of weekdays.
      Dictionary<string, string> weekDay = new Dictionary<string, string>()
      {
        {"Monday", "It's Monday, and they are the worst, but dont stress.\n"},
        {"Tuesday", "Well, it's a good things it's not Monday.\n"},
        {"Wednesday", "Wednesday and now we are playing: We are halfway there by Bon Jovi.\n"},
        {"Thursday", "I heard that on Thursdays you supposed to eat fish, but I don't really know.\n"},
        {"Friday", "Here is a little known fact. Fridays in Norway are known as Taco Friday.\nHow did the Mexicans get there, you ask? Beats me.\n"},
        {"Saturday", "It's Saturday!!! Finally I can do everything I planned, which is nothing.\n"},
        {"Sunday", "Oh no... Sunday is here... It means only one thing... Tomorrow is Monday.\n"},
      };

      // Store current time once and reuse it.
      DateTime currentTime = DateTime.Now;
      int currentHour = currentTime.Hour;
      DayOfWeek currentDay = currentTime.DayOfWeek;

      // Safe dictionary lookup — prevents crash if key is missing. this fancy thing found online. i am far away from such a lookup
      string weekDayComment;
      if (!weekDay.TryGetValue(currentDay.ToString(), out weekDayComment))
      {
        weekDayComment = "Have a good day!";
      }

      string startMsg = "Please enter your name for your greeting>>>\t";
      string greeting;
      string smallTalk;

      // Typing effect for intro message
      for (int i = 0; i < startMsg.Length; i++)
      {
        Thread.Sleep(15);
        Console.Write(startMsg[i]);
      }

      string userName = Console.ReadLine();

      // incase user enters nothing or just whitespaces
      if (string.IsNullOrWhiteSpace(userName))
      {
        userName = "Mysterio";
        Console.WriteLine($"Fine then, don't give me your name. I will call you... {userName} ooohhh (mystic sounds playing in background).\n");
      }

      // Decides greeting and small talk based on current time
      if (currentHour >= 6 && currentHour < 12)
      {
        greeting = "Top of the morning to you";
        if (currentHour < 9)
        {
          smallTalk = "How did you sleep?";
        }
        else if (currentHour < 11)
        {
          smallTalk = $"Sooo... {userName}, how is your morning so far?";
        }
        else
        {
          smallTalk = $"Soon is lunch time, make sure to eat something nutritious {userName}.";
        }
      }
      else if (currentHour >= 12 && currentHour < 18)
      {
        greeting = "Good afternoon";
        if (currentHour < 14)
        {
          smallTalk = $"I hope you had a good meal :)\nWe are nearly there, {userName}.";
        }
        else if (currentHour < 16)
        {
          smallTalk = $"Soon the fun starts, keep up {userName}!";
        }
        else
        {
          smallTalk = "Finally it's over.";
        }
      }
      else if (currentHour >= 18 && currentHour < 24)
      {
        greeting = "Good evening";
        if (currentHour < 21)
        {
          smallTalk = $"Did you do the dishes, {userName}?";
        }
        smallTalk = $"Those teeth of yours won't brush by themselves, {userName}.";
      }
      else // thats if it is between 00:00 - 05:59
      {
        greeting = "Good night";
        smallTalk = $"{userName}, it's late... you should be resting.";
      }

      // Final output message
      string finalOutPut = $"{greeting}, {userName}! Now is {currentTime:HH:mm}\n{smallTalk}\n{weekDayComment}";

      // Typing effect for final message
      for (int i = 0; i < finalOutPut.Length; i++)
      {
        Console.Write(finalOutPut[i]);
        Thread.Sleep(15);
      }
    }
  }
}
