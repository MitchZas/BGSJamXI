using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject EPrompt;
    [SerializeField] private GameObject dialogueCanvas;
    [SerializeField] private PlayerController playerControllerScript;
    private bool isPressed = false;

    private void Update()
    {
        if (isPressed)
            OpenDialogue();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EPrompt.SetActive(true);
            isPressed = true;
            Debug.Log("Collided");
        }

        if (gameObject.tag == "Suitor")
        {
            Debug.Log("Long Text");
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

    void OpenDialogue()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialogueCanvas.SetActive(true);
            Debug.Log("Dialogue open");
            playerControllerScript.moveSpeed = 0;
        }
    }
}
