using UnityEngine;

public class QuestDataSO : MonoBehaviour
{
    [System.Serializable]
    public struct Diglog
    {
        public string Dialog;
    }

    [CreateAssetMenu(fileName = "Quest Data", menuName = "SO/Quest Data")]
    public class DialogDataSO : ScriptableObject
    {
        public Diglog[] node = new Diglog[1];
    }
}
