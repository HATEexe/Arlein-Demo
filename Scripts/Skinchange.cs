using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Skinchange : MonoBehaviour
{
    //импорт кнопок интерфейса
    public Button aBtn, bBtn, menuBtn, startBnt;
    //получение скина консоли и кнопки крестовины 
    public Image consoleBody, xBtn;
    //переменная отображающая, какой скин в данный момент установлен. 0 - Classic, 1 - ColorBlue, 2 - ColorYellow,
    static public int skinNow;
    void Start()
    {
        skinNow = 0;
    }

    void Update()
    {
        switch (Food.score)
        {
            case 10:
                //при счете = 10 - происходит сменга скина консоли и кнопок
                consoleBody.sprite = SkinsLoad.colorGamerBlue[2];
                aBtn.image.sprite = SkinsLoad.colorGamerBlue[0];
                bBtn.image.sprite = SkinsLoad.colorGamerBlue[1];
                xBtn.sprite = SkinsLoad.colorGamerBlue[5];
                menuBtn.image.sprite = SkinsLoad.colorGamerBlue[3];
                startBnt.image.sprite = SkinsLoad.colorGamerBlue[4];
                //так же обновляется переменная "какой скин"
                skinNow = 1;
                break;
            case 15:
                //при счете = 15 - происходит сменга скина консоли и кнопок
                consoleBody.sprite = SkinsLoad.colorGamerYellow[2];
                aBtn.image.sprite = SkinsLoad.colorGamerYellow[0];
                bBtn.image.sprite = SkinsLoad.colorGamerYellow[1];
                xBtn.sprite = SkinsLoad.colorGamerBlue[5];
                menuBtn.image.sprite = SkinsLoad.colorGamerYellow[3];
                startBnt.image.sprite = SkinsLoad.colorGamerYellow[4];
                //так же обновляется переменная "какой скин"
                skinNow = 2;
                break;
        }
    }
}
