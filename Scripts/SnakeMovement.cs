using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class SnakeMovement : MonoBehaviour
{
    //переменная для изменения направления движения игрока
    private Vector2 moveDirection;
    //игрок
    public GameObject player;
    //название сцены, которая будет загружена
    private string SceneName = "GameOver";
    //переменная, которая заканчиванет игру при значении true
    private bool gameOver = false;
    //массив, в котором указаны сегменты змейки
    private List<Transform> segments;
    //ссылка на префаб сегмента для последующего копирования
    public Transform segmentPrefab;

    private void Start()
    {
        //добавление головы змекйи в массив
        segments = new List<Transform>();
        segments.Add(this.transform);
    }
    private void Update()
    {
        //считывание значение gameOver. Как только значние = true - меняет сцену на GameOver + обнуляет счетчкик очков
        if (gameOver == true)
        {
            SceneManager.LoadScene(SceneName);
            Food.score = 0;
        }
    }
    private void FixedUpdate()
    {
        //перебор массива с конца для передвижения сегментов
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }
        //перемещение игрока (головы змейки) по формуле 3.23 * каждая секунда
        player.transform.Translate(moveDirection * Time.deltaTime);

    }
    private void Grow()
    {
        //кописрование префаба сегмента и добавление его + его позиции в массив
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = segments[segments.Count - 1].position;

        segments.Add(segment);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //функция считывания входных данных коллайдера. Если тег объекта = Apple - активируется функция Grow
        if (other.tag == "Apple")
        {
            Grow();
        }
        //функция считывания входных данных коллайдера. Если тег объекта = NotApple - GameOver = true
        else if (other.tag == "NotApple")
            gameOver = true;

    }

    //функции управления, привязанныке к кнопкам интерфейса. if необходим для предотвращения движения головы змейки в хвост 
    public void MoveUp()
    {
        if (moveDirection != new Vector2(0f, -3.23f))
            moveDirection = new Vector2(0f, 3.23f);
    }
    public void MoveDown()
    {
        if (moveDirection != new Vector2(0f, 3.23f))
            moveDirection = new Vector2(0f, -3.23f);
    }
    public void MoveRight()
    {
        if (moveDirection != new Vector2(-3.23f, 0f))
            moveDirection = new Vector2(3.23f, 0f);
    }
    public void MoveLeft()
    {
        if (moveDirection != new Vector2(3.23f, 0f))
            moveDirection = new Vector2(-3.23f, 0f);
    }
}
