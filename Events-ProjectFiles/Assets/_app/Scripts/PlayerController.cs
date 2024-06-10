using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector2 = UnityEngine.Vector2;

namespace _app.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        private void OnEnable()
        {
            DelegateManager.deathEvent += OnDeath;
        }

        private void OnDisable()
        {
            DelegateManager.deathEvent -= OnDeath;
        }

        public void PlayerMovement(InputAction.CallbackContext context)
        {
            // movement logic
            transform.Translate(context.ReadValue<Vector2>() * Time.deltaTime);
            Debug.Log(context.ReadValue<Vector2>().ToString());
        }
        
        // the player dies (sad)
        public void OnDeath()
        {
            Destroy(this.gameObject);
        }
    }
}
