
using System;

/// <summary>
/// The user class, which gets uploaded to the Firebase Database
/// </summary>

[Serializable] // This makes the class able to be serialized into a JSON
public class User
{
    public string name;
    public string gender;
    public int age;
    public string height;
    public string weight;
    public string skin;
    public string hair;

    public User(string name, string gender, int age, string height,string weight, string skin, string hair)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
        this.height = height;
        this.weight = weight;
        this.skin = skin;
        this.hair = hair;
        
    }
}

