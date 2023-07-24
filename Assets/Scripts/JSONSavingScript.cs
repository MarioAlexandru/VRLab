using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.IO;

public class JSONSavingScript : MonoBehaviour
{
    [System.Serializable]
    public class SerializableList<T>
    {
        public List<T> list;
    }

    public TMP_InputField inputField;

    public string FileToSaveTo;

    //private List<string> journalEntries = new List<string>();
    private SerializableList<string> journalEntries = new SerializableList<string>();
    private string journalFilePath;

    

    private void Awake()
    {
        // Set the path where the journal data will be stored
        journalFilePath = Path.Combine(Application.persistentDataPath, FileToSaveTo);
        if (journalEntries.list == null) journalEntries.list = new List<string>(); 

        // Load existing journal entries
        LoadJournal();
    }

    private void LoadJournal()
    {
        if (File.Exists(journalFilePath))
        {
            string jsonData = File.ReadAllText(journalFilePath);
            if (jsonData != "")
            {
                journalEntries = JsonUtility.FromJson<SerializableList<string>>(jsonData);
                DisplayJournalEntries();
            }
        }
        else
        {
            File.Create(journalFilePath);
        }    
    }

    private void SaveJournal()
    {
        //string jsonData = JsonUtility.ToJson(journalEntries);
        string jsonRead = File.ReadAllText(journalFilePath);
        string jsonData = JsonUtility.ToJson(journalEntries);
        if(jsonRead != jsonData) File.WriteAllText(journalFilePath, jsonData);
    }

    private void DisplayJournalEntries()
    {
        // Clear the input field
        inputField.text = "";

        // Display the journal entries
        foreach (string entry in journalEntries.list)
        {
            inputField.text += entry;
        }
    }

    public void AddEntry()
    {
        if (!string.IsNullOrEmpty(inputField.text))
        {
            string newEntry = inputField.text;
            string jsonRead = File.ReadAllText(journalFilePath);

            if (jsonRead == "")
            {
                journalEntries.list.Add(newEntry);
                SaveJournal();
                DisplayJournalEntries();
            }
            else
            {
                if (!jsonRead.Contains(newEntry))
                {
                    journalEntries.list[0] = newEntry;
                    SaveJournal();
                    DisplayJournalEntries();
                }
            }
        }
    }
}