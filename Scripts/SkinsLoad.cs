using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsLoad : MonoBehaviour
{
    //массивы скинов
    static public Sprite[] classicGamer;
    static public Sprite[] colorGamerBlue;
    static public Sprite[] colorGamerYellow;

    void Start()
    {
        //загрузка элементов скинов консоли в массивы из соответствующих папок
        classicGamer = Resources.LoadAll<Sprite>("ConsoleSkins/ClassicGamer");
        colorGamerBlue = Resources.LoadAll<Sprite>("ConsoleSkins/ColorGamer/Blue");
        colorGamerYellow = Resources.LoadAll<Sprite>("ConsoleSkins/ColorGamer/Yellow");
    }
}
