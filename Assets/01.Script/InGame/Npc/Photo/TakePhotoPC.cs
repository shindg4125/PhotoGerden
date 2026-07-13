using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace _01.Script.Npc.Photo
{
    public class TakePhotoPC : MonoBehaviour
    {
        [SerializeField] private GameObject _particle;
        [SerializeField] private GameObject photo;
        [SerializeField] private GameObject panel;
        [SerializeField] private TextMeshProUGUI text;

        [SerializeField] private int Index;
        [SerializeField] private GameObject _dontMove;

        private void Awake()
        {
            _dontMove.SetActive(false);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _dontMove.SetActive(true);
            Debug.Log(collision.gameObject.name);
            panel.SetActive(true);
            text.text = "음..? 이건 사진...?"; 
            StartCoroutine(SystemTxt()); 
        }

        IEnumerator SystemTxt()
        {
            yield return new WaitForSeconds(1f);
            CheckIndex();
            yield return new WaitForSeconds(1f);
            text.text = "( 앨범을 확인해보자. )";
            yield return new WaitForSeconds(1f);
            _dontMove.SetActive(false);
            CantUse();
            yield return new WaitForSeconds(0.1f);
            gameObject.SetActive(false);
        }

        private void CantUse()
        {
            Debug.Log("asdasd");
            photo.SetActive(true);
            panel.SetActive(false);
            _particle.SetActive(false);
        }

        private void CheckIndex()
        {
            if(Index == 1 || Index == 2 || Index == 3)
                text.text = "언제 찍었는지 모르는 사진이다.."; 
            if(Index == 4)
                text.text = "여기에서 찍은 사진이 아닌 것 같다.."; 
        }
    }
}
