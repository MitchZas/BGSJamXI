using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueObject;

// INFO: This whole script was ripped from the linked code in the description of Matthew Ventures' video - https://www.youtube.com/watch?v=cmafUgj1cu8&t=319s
public class DialogueController : MonoBehaviour
{
    [SerializeField] BooCalculator booCalculatorScript;
    
    public bool isGood = false;
    public bool isNeutral = false;
    public bool isBad = false;

    [SerializeField] BooCalculator booCalcuatorScript;
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
        int loveMeterPoints = curNode.responses[responseIndex].displayText == "GOOD" ? 5 : 
                curNode.responses[responseIndex].displayText == "NEUTRAL" ? 0 : -5;
            booCalcuatorScript.SetLove(loveMeterPoints);

        isGood = curNode.responses[responseIndex].displayText == "GOOD";
        isNeutral = curNode.responses[responseIndex].displayText == "NEUTRAL";
        isBad = curNode.responses[responseIndex].displayText == "BAD";

        string nextNodeID = curNode.responses[responseIndex].destinationNode;
        Node nextNode = curDialogue.GetNode(nextNodeID);
        curNode = nextNode;
        onEnteredNode(nextNode);
    }
}