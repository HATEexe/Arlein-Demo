using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartNew : MonoBehaviour
{
    //импорт кнопок интерфейса
    public Button aBtn, bBtn, menuBtn, startBnt;

    //получение скина консоли и кнопки крестовины 
    public Image consoleBody, xBtn;

    void Start()
    {
        //форму switch срабатывает на переменную в которой указан счет игрока
        switch (Skinchange.skinNow)
        {
            case 0:
                //Classic
                consoleBody.sprite = SkinsLoad.classicGamer[2];
                aBtn.image.sprite = SkinsLoad.classicGamer[0];
                bBtn.image.sprite = SkinsLoad.classicGamer[1];
                xBtn.sprite = SkinsLoad.classicGamer[5];
                menuBtn.image.sprite = SkinsLoad.classicGamer[3];
                startBnt.image.sprite = SkinsLoad.classicGamer[4];
                break;
            case 1:
                //ColorBlue
                consoleBody.sprite = SkinsLoad.colorGamerBlue[2];
                aBtn.image.sprite = SkinsLoad.colorGamerBlue[0];
                bBtn.image.sprite = SkinsLoad.colorGamerBlue[1];
                xBtn.sprite = SkinsLoad.colorGamerBlue[5];
                menuBtn.image.sprite = SkinsLoad.colorGamerBlue[3];
                startBnt.image.sprite = SkinsLoad.colorGamerBlue[4];
                break;
            case 2:
                //ColorYellow
                consoleBody.sprite = SkinsLoad.colorGamerYellow[2];
                aBtn.image.sprite = SkinsLoad.colorGamerYellow[0];
                bBtn.image.sprite = SkinsLoad.colorGamerYellow[1];
                xBtn.sprite = SkinsLoad.colorGamerBlue[5];
                menuBtn.image.sprite = SkinsLoad.colorGamerYellow[3];
                startBnt.image.sprite = SkinsLoad.colorGamerYellow[4];
                break;
        }
    }
    //переменная с названием сцены, которая будет загружена
    private string sceneName = "GameOver";
    public void StartNewGame()
    {
        //загрузка сцены, название которой указанно в переменной
        SceneManager.LoadScene(sceneName);
    }
}
