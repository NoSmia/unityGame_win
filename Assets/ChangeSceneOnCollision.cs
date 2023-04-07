using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public int indexScene; //переменна€ чтобы указать номер сцены
    public int restartScene; //переменна€ чтобы указать номер сцены


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if дл€ перезапуска уровн€
        {
            SceneManager.LoadScene(restartScene);
        }
    }

    public void btSelectScene() //функиц€
    {
        SceneManager.LoadScene(indexScene); //дл€ нажати€ на кнопок и перехода на сцену
    }
}