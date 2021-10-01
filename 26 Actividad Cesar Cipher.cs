using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.Write("Introduce el mensaje secreto: ");
      string secretMessage=Console.ReadLine();

      char[] encryptedMessage=new char[secretMessage.Length];

      for(int i=0;i<secretMessage.Length;i++){
        char letra=secretMessage[i];
        int posicion=Array.IndexOf(alphabet,letra);
        posicion=(posicion+3)%alphabet.Length;
        letra=alphabet[posicion];
        encryptedMessage[i]=letra;
      }
      String secreto=String.Join("",encryptedMessage);
      Console.WriteLine(secreto);
    }
  }
}