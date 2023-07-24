using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextLoader : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Reference to the Text component in the scene

    private void Start()
    {
        // Check if the saved text exists in PlayerPrefs
        if (PlayerPrefs.HasKey("SavedText"))
        {
            // Load the saved text and display it
            string savedText = PlayerPrefs.GetString("SavedText");
            displayText.text = savedText;
        }
        else
        {
            // Default text if no saved text is found
            displayText.text = "No saved text found.";
        }
    }
}