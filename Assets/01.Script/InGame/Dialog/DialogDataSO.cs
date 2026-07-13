using UnityEngine;

[System.Serializable] // 구조체 직렬화
public struct Diglog // 대화 구조체
{
    public string Name;
    [TextArea]
    public string Dialog;
}

[CreateAssetMenu(fileName = "Dialog Data", menuName = "SO/Dialog Data")] // ScriptableObject로 대화 데이터를 저장하기 위한 클래스
public class DialogDataSO : ScriptableObject // 대화 데이터를 저장하기 위한 ScriptableObject 클래스
{
    public Diglog[] node = new Diglog[1];
    public bool canDialog; // 대화 가능 여부
}
