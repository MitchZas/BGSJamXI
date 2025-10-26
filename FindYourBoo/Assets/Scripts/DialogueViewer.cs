using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Runtime.InteropServices;
using static DialogueObject;

// INFO: This whole script was ripped from the linked code in the description of Matthew Ventures' video - https://www.youtube.com/watch?v=cmafUgj1cu8&t=319s
// and his second video - https://www.youtube.com/watch?v=x40Fbeuu3QU

public class DialogueViewer : MonoBehaviour
{
    [SerializeField] Transform _parentOfAnswers;
    [SerializeField] Button _prefab_btnResponse;
    [SerializeField] TMPro.TMP_Text _txtMessage;
    [SerializeField] DialogueController _dialogueController;
    [SerializeField] private GameObject closeDialogueBox;
    DialogueController _controller;

    [DllImport("__Internal")]
    private static extern void openPage(string url);

    private void Start()
    {
        _controller = _dialogueController;
        _controller.onEnteredNode += OnNodeEntered;
        _controller.InitializeDialogue();

        // Start dialogue
        var curNode = _controller.GetCurrentNode();
    }

    public static void KillAllChildren(UnityEngine.Transform parent)
    {
        UnityEngine.Assertions.Assert.IsNotNull(parent);
        for (int childIndex = parent.childCount - 1; childIndex >= 0; childIndex--)
        {
            UnityEngine.Object.Destroy(parent.GetChild(childIndex).gameObject);
        }
    }

    private void OnNodeSelected(int indexChosen)
    {
        Debug.Log("Chose: " + indexChosen);
        _controller.ChooseResponse(indexChosen);
    }

    private void OnNodeEntered(Node newNode)
    {
        _txtMessage.text = newNode.text;
        KillAllChildren(_parentOfAnswers);

        for (int i = newNode.responses.Count - 1; i >= 0; i--)
        {
            int currentChoiceIndex = i;
            var response = newNode.responses[i];
            var responceButton = Instantiate(_prefab_btnResponse, _parentOfAnswers);

            if (!newNode.tags.Contains("END"))
            {
                responceButton.GetComponentInChildren<TMPro.TMP_Text>().text = (response.destinationNode);
            }
            else
            {
                responceButton.GetComponentInChildren<TMPro.TMP_Text>().text = (string.Empty);
                closeDialogueBox.SetActive(true);
            }

            responceButton.onClick.AddListener(delegate { OnNodeSelected(currentChoiceIndex); });
        }

    }

    public static Sprite Texture2DToSprite(Texture2D t)
    {
        return Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f));
    }
}