using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreanChanger : MonoBehaviour
{
    // 버튼에서 OnClick()으로 연결
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Lecture03"); // 씬 이름으로 이동
        // 또는 인덱스로 이동 가능: SceneManager.LoadScene(1);
    }
}