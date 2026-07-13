using UnityEngine;
using UnityEngine.Events;

public class DialogController : MonoBehaviour
{
    public static DialogController Instance;

    public UnityEvent<DialogDataSO> OnEnter;
    public UnityEvent OnExit;

    public DialogDataSO[] DialogDatas;

    public int _questIndex;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
            Destroy(gameObject);
    }
}