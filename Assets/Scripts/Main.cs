using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    [SerializeField] GameObject titleScreen;
    [SerializeField] GameObject victoryText;
    [SerializeField] Button renameButton;
    [SerializeField] Button nameButton;
    [SerializeField] TMP_Text welcomeText;
    [SerializeField] TMP_InputField enterName;
    [SerializeField] Button abstrButton;
    [SerializeField] Button inherButton;
    [SerializeField] Button polymButton;
    [SerializeField] Button encapButton;
    [SerializeField] TMP_Text failText;
    public TMP_Text errorText;
    public bool isQ1Ans = false;
    public bool isQ2Ans = false;
    public bool isQ3Ans = false;
    public bool isQ4Ans = false;
    public int qNum = 0;

    //ENCAPSUALTION
    private string m_name = "name";
    public string name
    {
        get { return m_name; }
        set
        {
            if (name.Length > 15)
            {
                Debug.LogError("Name should contain less than 15 characters");
            }
            else
            {
                m_name = value;
            }
        }
    }

    private void Update()
    {
        if (isQ1Ans && isQ2Ans && isQ3Ans && isQ4Ans)
            victoryText.SetActive(true);
        //ABSTRACTION
        SetUpButtons();

        if(qNum != 0)
        {
            string end;
            if(qNum == 1)
            {
                end = "n";
            }
            else
            {
                end = "ns";
            }
            failText.gameObject.SetActive(true);
            failText.text = "You have answered " + qNum + " questio" + end + " wrong.";
        }
    }

    private void Awake()
    {
        LoadData();
    }

    public void Quit()
    {
        //ABSTRACTION
        SaveData();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public class PlayerData
    {
        public string name;
        public bool isQ1Ans;
        public bool isQ2Ans;
        public bool isQ3Ans;
        public bool isQ4Ans;
    }

    void SaveData()
    {
        PlayerData data = new PlayerData();

        data.name = name;
        data.isQ1Ans = isQ1Ans;
        data.isQ2Ans = isQ2Ans;
        data.isQ3Ans = isQ3Ans;
        data.isQ4Ans = isQ4Ans;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            isQ1Ans = data.isQ1Ans;
            isQ2Ans = data.isQ2Ans;
            isQ3Ans = data.isQ3Ans;
            isQ4Ans = data.isQ4Ans;
            name = data.name;
            //ABSTRACTION
            SetUpName();
            SetUpButtons();
        }
    }

    public void EnterName()
    {
        if (enterName.text.Length > 15)
        {
            errorText.text = "Name should contain less than 15 characters";
            errorText.gameObject.SetActive(true);
        }
        else if (enterName.text.Length == 0)
        {
            errorText.text = "Please, enter your name";
            errorText.gameObject.SetActive(true);
        }
        else
        {
            name = enterName.text;
            //ABSTRACTION
            SetUpName();

            if (errorText.gameObject.activeSelf == true)
                errorText.gameObject.SetActive(false);

        }
    }

    public void RenameButton()
    {
        name = "name";
        welcomeText.gameObject.SetActive(false);
        renameButton.gameObject.SetActive(false);
        enterName.gameObject.SetActive(true);
        nameButton.gameObject.SetActive(true);

        isQ1Ans = false;
        isQ2Ans = false;
        isQ3Ans = false;
        isQ4Ans = false;

        abstrButton.image.color = Color.white;
        inherButton.image.color = Color.white;
        polymButton.image.color = Color.white;
        encapButton.image.color = Color.white;

        victoryText.SetActive(false);
    }

    void SetUpName()
    {
        if(name != "name")
        {
            welcomeText.text = "Welcome " + name;
            welcomeText.gameObject.SetActive(true);
            renameButton.gameObject.SetActive(true);
            enterName.gameObject.SetActive(false);
            nameButton.gameObject.SetActive(false);
        }
    }
    void SetUpButtons()
    {
        if (isQ1Ans == true)
        {
           abstrButton.image.color = Color.green;
        }
        if (isQ2Ans == true)
        {
            inherButton.image.color = Color.green;
        }
        if (isQ3Ans == true)
        {
            polymButton.image.color = Color.green;
        }
        if (isQ4Ans == true)
        {
            encapButton.image.color = Color.green;
        }
    }
}
