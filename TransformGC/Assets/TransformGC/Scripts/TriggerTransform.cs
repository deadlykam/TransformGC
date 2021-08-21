using UnityEngine;

public class TriggerTransform : MonoBehaviour
{
    [Header("TriggerTransform Local Properties")]
    [SerializeField] private bool _isPreloadTransform;

    private void Awake() { if (_isPreloadTransform) transform.localPosition = transform.localPosition; } // Triggering transform for preloading it at start up
    private void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.T)) transform.localPosition = transform.localPosition; // Pressing T triggers transform
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit(); // Qutting the game
    }
}
