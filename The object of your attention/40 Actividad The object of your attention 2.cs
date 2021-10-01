using System;

namespace DatingProfile
{ 
  class Profile{
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns="they/them"){
      this.name=name;
      this.age=age;
      this.city=city;
      this.country=country;
      this.pronouns=pronouns;
      this.hobbies=new string[0];
    }

    public string ViewProfile(){
      string cadena= $"Nombre: {name}, edad: {age}, ciudad: {city}, país: {country}, pronombres: {pronouns} y hobbies: ";
      foreach(string hobby in hobbies){
       cadena+=hobby+", ";
      }
      return cadena;
    }

    public void SetHobbies(string[] hobbies){
      this.hobbies=hobbies;
    }
    
  }
}
