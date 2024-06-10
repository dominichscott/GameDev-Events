using UnityEngine;
using UnityEngine.Events;

public class DelegateManager : MonoBehaviour
{
    public delegate void eventDelegate();
    public static eventDelegate scoreEvent;
    public static eventDelegate deathEvent;
    public static eventDelegate speakEvent;
    
    public delegate void StringEvent(string s);

    public static StringEvent stringEvent;
    
    public UnityEvent OnEndGame;

    private void Update()
    {
        OnEndGame?.Invoke();
    }

    public void DebugGameOver()
    {
        Debug.Log("Game Over");
    }
}
