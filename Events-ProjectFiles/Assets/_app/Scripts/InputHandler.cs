using System;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            DelegateManager.scoreEvent?.Invoke();
            DelegateManager.stringEvent?.Invoke("Hello");
            DelegateManager.speakEvent?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            DelegateManager.deathEvent?.Invoke();
        }
    }
}
