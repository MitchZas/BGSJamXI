using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueObject;

// INFO: This whole script was ripped from the linked code in the description of Matthew Ventures' video - https://www.youtube.com/watch?v=cmafUgj1cu8&t=319s
public class DialogueController : MonoBehaviour
{

    [SerializeField] TextAsset twineText;
    Dialogue curDialogue;
    Node curNode;

    public delegate void NodeEnteredHandler(Node node);
    public event NodeEnteredHandler onEnteredNode;

    public Node GetCurrentNode()
    {
        return curNode;
    }

    public void InitializeDialogue()
    {
        curDialogue = new Dialogue(twineText);
        curNode = curDialogue.GetStartNode();
        onEnteredNode(curNode);
    }

    public List<Response> GetCurrentResponses()
    {
        return curNode.responses;
    }

    public void ChooseResponse(int responseIndex)
    {
        // TODO: This is where the response is chosen and I need to call the SetLove() function from Jonathan's code.
        // Before you do any of the un-commented out code below, implement this code:
        /*
            int loveMeterPoints = curNode.responses[responseIndex].displayText == "GOOD" ? 10 : 
                curNode.responses[responseIndex].displayText == "NEUTRAL" ? 5 : 0;
            jonathansScript.SetLove(loveMeterPoints);
         */


        string nextNodeID = curNode.responses[responseIndex].destinationNode;
        Node nextNode = curDialogue.GetNode(nextNodeID);
        curNode = nextNode;
        onEnteredNode(nextNode);
    }
}