using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject EPrompt;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EPrompt.SetActive(true);
            Debug.Log("Collided");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EPrompt.SetActive(false);
            Debug.Log("Left");
        }
    }
}
