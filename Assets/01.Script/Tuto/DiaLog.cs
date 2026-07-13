using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiaLog : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        panel.SetActive(true);
        StartCoroutine(Dialog());
    }

    IEnumerator Dialog()
    {
        text.text = "저는 튜토리얼을 맡은 설명인입니다.";
        yield return new WaitForSeconds(3f);
        text.text = "우선 이 게임은 BGM밖에 존재하지 않습니다.";
        yield return new WaitForSeconds(3f);
        text.text = "인게임 내에서 ESC를 눌러 BGM 조절이 가능합니다.";
        yield return new WaitForSeconds(3f);
        text.text = "WASD로 움직이며";
        yield return new WaitForSeconds(3f);
        text.text = "G키로 앨범을, H키로 퀘스트창을 열람 가능합니다.";
        yield return new WaitForSeconds(3f);
        text.text = "이 게임에는 ai 이미지가 한장 들어있습니다.";
        yield return new WaitForSeconds(3f);
        text.text = "만약 ai 이미지에서 거부감이 드신다면";
        yield return new WaitForSeconds(3f);
        text.text = "미리 죄송한 말을 올립니다.";
        yield return new WaitForSeconds(3f);
        text.text = "그럼 시작하겠습니다.";
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game");
    }
}
