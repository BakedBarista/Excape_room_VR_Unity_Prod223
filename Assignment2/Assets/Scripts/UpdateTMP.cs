using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Reference to the TextMeshPro component for displaying text
    public string newText = "New Text"; // The new text to be displayed
    public string redCombination = "341";
    public string greenCombination = "1010";
    private static string combinationEntered = "";
    public GameObject redBall;
    public GameObject greenBall;

    public void ChangeTextContent()
    {
        // Check if the TextMeshPro component is assigned
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshPro component is not assigned.");
            return;
        }

        // Change the text content of the TextMeshPro component
        if (textMeshPro.text.Length < 4)
        {
            textMeshPro.text = combinationEntered += newText;
        }
        
    }

    public void CheckCombination()
    {
        if (combinationEntered == redCombination)
        {
            textMeshPro.text = "RED";
            redBall.SetActive(true);
        }
        else if (combinationEntered == greenCombination)
        {
            textMeshPro.text = "GREEN";
            greenBall.SetActive(true);
        }
    }

    public void Clear()
    {
        combinationEntered = "";
        textMeshPro.text = combinationEntered;
    }
}
