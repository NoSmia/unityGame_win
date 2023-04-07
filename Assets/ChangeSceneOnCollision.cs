using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public int indexScene; //���������� ����� ������� ����� �����
    public int restartScene; //���������� ����� ������� ����� �����


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if ��� ����������� ������
        {
            SceneManager.LoadScene(restartScene);
        }
    }

    public void btSelectScene() //�������
    {
        SceneManager.LoadScene(indexScene); //��� ������� �� ������ � �������� �� �����
    }
}