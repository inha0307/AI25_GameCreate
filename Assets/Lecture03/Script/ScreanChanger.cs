using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreanChanger : MonoBehaviour
{
    // ��ư���� OnClick()���� ����
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Lecture03"); // �� �̸����� �̵�
        // �Ǵ� �ε����� �̵� ����: SceneManager.LoadScene(1);
    }
}