using UnityEngine;
using UnityEngine.SceneManagement;

public class StatScene : MonoBehaviour
{
    public void SceneChanger()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
