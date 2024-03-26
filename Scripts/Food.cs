using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Food : MonoBehaviour
{
    //импорт игрового объекта "яблоко"
    public GameObject apple;
    //переменная счета. обновляется при поедании яблока (так же отсылается в скрипт для смены скина консоли)
    static public int score;
    //импорт поля, где бует выводится счет
    public TextMeshProUGUI scoreField;
    public BoxCollider2D bc;
    private void RandomPos()
    {
        //яблоко спаунится случайно в определенном радиусе
        apple.transform.position = new Vector2(Random.Range(-1.5f, 1.5f), Random.Range(3.5f, 0.7f));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //при соприкосновении хит-бокса игрока и яблока вызывается функция RandomPos, + 1 очко и его вывод
        if (other.tag == "Player")
        {
            score += 1;
            scoreField.text = "" + score;
            RandomPos();
        }

    }
}
