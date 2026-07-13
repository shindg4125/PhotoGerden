using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _01.Script.Object
{
    public class SkipFadeInOut : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _nextDay;
        
        [SerializeField] private GameObject _nextDayButton;
        
        [SerializeField] private GameObject _panel;
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private TextMeshProUGUI _textButtonOne;
        
        
        [SerializeField] private GameObject _dontMove;
        [SerializeField] private GameObject door;

        private void Awake()
        {
            _dontMove.SetActive(false);
            _nextDayButton.SetActive(false);
            _nextDay = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            CloseButton();
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                StartButton();
                _text.text = " 다음날로 갈까? ";
                _textButtonOne.text = " 넘어가자 ";
            }
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            CloseButton();
        }

        public void OnClick()
        {
            CloseButton();
        }
    
        public void Realized()
        {
            CloseButton();
            FadeIn();
            StartCoroutine(FadeOut());
        }

        private void FadeIn()
        {
            _nextDay.enabled = true;
            
            _dontMove.SetActive(true);
            _nextDay.DOFade(10f, 3f).SetEase(Ease.InOutCubic).SetUpdate(true);
        }

        IEnumerator FadeOut()
        {
            _nextDay.enabled = true;
            
            yield return new WaitForSeconds(2f);
            _nextDay.DOFade(0f, 3f).SetEase(Ease.InOutCubic);
            _dontMove.SetActive(false);
            door.SetActive(false);
        }

        private void StartButton()
        {
            _panel.SetActive(true);
            _nextDayButton.SetActive(true);

        }
        private void CloseButton()
        {
            _panel.SetActive(false);
            _nextDayButton.SetActive(false);

        }
    }
}
