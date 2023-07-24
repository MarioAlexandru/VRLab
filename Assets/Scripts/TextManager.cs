using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TMP_InputField inputField; // Reference to the InputField in the scene

    // Function to save the text to PlayerPrefs
    public void SaveText()
    {
        string textToSave = inputField.text;
        PlayerPrefs.SetString("SavedText", textToSave);
        PlayerPrefs.Save();
    }
    private void Start()
    {
        string textSaved = PlayerPrefs.GetString("SavedText");
        inputField.text = textSaved;
    }
}