using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCDialog : MonoBehaviour, IDialogState
{
    public int _index;
    private int _QuestIndex = 1;
    
    [SerializeField] private DialogDataSO _dialogDataSO;

    public TextMeshProUGUI _questOneTxt;
    public TextMeshProUGUI _questTwoTxt;
    public TextMeshProUGUI _questThreeTxt;

    private bool _isZone; // false
    private bool _isUIOpen; // false
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other == null) return;
        if (!other.CompareTag("Player") && !_isZone) return;
        _isZone = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _isZone = false;
        _isUIOpen = false;
        Exit();
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && _isZone && !_isUIOpen && _dialogDataSO.canDialog)
        {
            Enter(_dialogDataSO);
            if (DialogController.Instance.DialogDatas.Length <= _index + 1) return;
            DialogController.Instance.DialogDatas[_index + 1].canDialog = true;

            CheckQst();
        }
    }
    
    private void CheckQst()
    {
        if (gameObject.name == "NPC1")
            _questOneTxt.text = $"멈춰버린 풍차";
                
        else if (gameObject.name == "NPC3")
            _questTwoTxt.text = $"유리병 속의 편지";

        else if (gameObject.name == "NPC5")
            _questThreeTxt.text = $"추억의 열매";
        else
            Debug.Log("NotThing");
    }

    public void Enter(DialogDataSO dialogDataSO)
    {
        DialogController.Instance.OnEnter?.Invoke(_dialogDataSO);
    }

    public void Exit()
    {
        DialogController.Instance.OnExit?.Invoke();
    }
}
