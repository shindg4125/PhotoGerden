using System.Collections;
using System.Linq;
using _01.Script.Player;
using TMPro;
using UnityEngine;

public class DiglogPresent : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI talkText;
    [SerializeField] private GameObject talkPanel;
    [SerializeField] private float _timeDelay = 0.05f;

    private DialogDataSO dialogDataSO;

    private Coroutine _typingCoroutine;
    private WaitForSeconds _waitForSeconds;

    private bool _isTyping;
    private int _index = 0;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_timeDelay > 0 ? _timeDelay : 0.02f);
    }

    private void Start()
    {
        DialogController.Instance.OnEnter.AddListener(HandleEnter);
        DialogController.Instance.OnExit.AddListener(HandleExit);
    }

    private void OnDisable()
    {
        if (DialogController.Instance != null)
        {
            DialogController.Instance.OnEnter.RemoveListener(HandleEnter);
            DialogController.Instance.OnExit.RemoveListener(HandleExit);
        }
    }

    public void HandleEnter(DialogDataSO _dialogData)
    {
        PlayerMovmentCompo.CanManualMove = false;
        dialogDataSO = _dialogData;
        talkPanel.SetActive(true);
        OnTyping();
    }

    private void OnTyping()
    {
        Debug.Log(_isTyping);
        if (dialogDataSO == null || dialogDataSO.node.Count() <= _index)
        {
            Debug.Log("node Length < index");
            HandleExit();
            return;
        }

        if (_isTyping)
        {
            if (_typingCoroutine != null)
            {
                StopCoroutine(_typingCoroutine);
                _typingCoroutine = null;
            }

            talkText.text = dialogDataSO.node[_index].Dialog; 
            _index++;                                         
            _isTyping = false;                                
        }
        else
        {
            talkText.text = "";
            _isTyping = true;
            _typingCoroutine = StartCoroutine(typingCoroutine(_index));
        }
    }

    private IEnumerator typingCoroutine(int index)
    {
        foreach (char c in dialogDataSO.node[index].Dialog)
        {
            talkText.text += c;
            yield return _waitForSeconds;
        }
        _isTyping = false;
        _index++;
        _typingCoroutine = null;
    }

    public void HandleExit()
    {
        if (_typingCoroutine != null)
        {
            StopCoroutine(_typingCoroutine);
            _typingCoroutine = null;
        }
        _index = 0;
        _isTyping = false;
        PlayerMovmentCompo.CanManualMove = true;
        talkPanel.SetActive(false);
    }
}