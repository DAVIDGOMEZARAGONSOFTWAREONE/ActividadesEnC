using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      //BuildACreature("bug","monster","ghost");
      //SwitchCase(1,1,1);
      RandomMode();
      int head=TranslateToNumber("ghost");
      int body=TranslateToNumber("bug");
      int feet=TranslateToNumber("monster");
      SwitchCase(head,body,feet);
    }

    /*static void BuildACreature(string head, string body, string feet){
      switch(head){
        case "bug":BugHead();
        break;
        case "monster":MonsterHead();
        break;
        case "ghost":GhostHead();
        break;
        default:Console.Write("Error");
        break;
      }
      switch(body){
        case "bug":BugBody();
        break;
        case "monster":MonsterBody();
        break;
        case "ghost":GhostBody();
        break;
        default:Console.Write("Error");
        break;
      }
      switch(feet){
        case "bug":BugFeet();
        break;
        case "monster":MonsterFeet();
        break;
        case "ghost":GhostFeet();
        break;
        default:Console.Write("Error");
        break;
      }
    }*/

    static void SwitchCase(int head,int body,int feet){
      switch(head){
        case 1:GhostHead();
        break;
        case 2:BugHead();
        break;
        case 3:MonsterHead();
        break;
        default:Console.Write("Error");
        break;
      }  
      switch(body){
        case 1:GhostBody();
        break;
        case 2:MonsterBody();
        break;
        case 3:BugBody();
        break;
        default:Console.Write("Error");
        break;
      }
      switch(feet){
        case 1:GhostFeet();
        break;
        case 2:MonsterFeet();
        break;
        case 3:BugFeet();
        break;
        default:Console.Write("Error");
        break;
      }    
    }

    static int TranslateToNumber(string creature){
      switch(creature){
        case "ghost": return 1;
        case "bug": return 2;
        case "monster": return 3;
        default: return 1;
      }
    }

    static void RandomMode(){
      Random randomNumber=new Random();
      int head = randomNumber.Next(1, 4);
      int body = randomNumber.Next(1, 4);
      int feet = randomNumber.Next(1, 4);
      SwitchCase(head,body,feet);
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}