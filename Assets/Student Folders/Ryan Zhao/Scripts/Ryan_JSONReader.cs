using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Static class that has the JSON manager code on it
public static class Ryan_JSONReader
{
    public static Ryan_LevelJSON ParseJSON(string txt)
    {
        return JsonUtility.FromJson<Ryan_LevelJSON>(txt);
    }
}

//Your JSON files should only have these variables in them
[System.Serializable]
public class Ryan_LevelJSON
{
    public string Title;
    public string Author;
    public List<Ryan_EventJSON> Events;
}

//These are the only valid variables for your Event objects
[System.Serializable]
public class Ryan_EventJSON
{
    public float Time;
    public string Anim;
    public string Action;
    public float Amt;
    public string Dialogue;
    public string Who;
}