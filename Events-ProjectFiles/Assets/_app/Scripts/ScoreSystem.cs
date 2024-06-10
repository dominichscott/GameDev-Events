using UnityEngine;

public class ScoreSystem : MonoBehaviour, ISpeakable
{
    private int _score;

    private void OnEnable()
    {
        DelegateManager.scoreEvent += OnScore;
        DelegateManager.deathEvent += OnDeath;
        DelegateManager.stringEvent += OnString;
        DelegateManager.speakEvent += Speak;
    }

    private void OnDisable()
    {
        DelegateManager.scoreEvent -= OnScore;
        DelegateManager.scoreEvent -= OnDeath;
        DelegateManager.stringEvent -= OnString;
        DelegateManager.speakEvent -= Speak;
    }

    public void OnScore()
    {
        _score++;
        Debug.Log(_score);
    }

    public void OnDeath()
    {
        _score = 0;
        Debug.Log("Game Over, score reset");
    }

    public void OnString(string s)
    {
        Debug.Log(s);
    }

    public void Speak()
    {
        Debug.Log("I have spoken!");
    }
}
