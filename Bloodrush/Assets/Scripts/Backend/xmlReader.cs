using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Xml;

[System.Serializable]
public class Elements
{
    public Button test;
    public GameObject bla;
}

public enum Languages
{
    English,
    German
};

public class xmlReader : MonoBehaviour
{ 
    public TextAsset dictionary;
    public string languageName;
    public Languages value;

    public Elements elem;
    int currentLanguage = (int)Languages.English;
    //string Button1;
    //string Button2;
    List<Dictionary<string,string>> languages = new List<Dictionary<string, string>>();
    Dictionary<string, string> obj;

    void Awake()
    {
        Reader();
    }

    void Update()
    {
        switch (value)
        {
            case Languages.English:
                currentLanguage = (int)Languages.English;
                UpdateLanguage();
                break;
            case Languages.German:
                currentLanguage = (int)Languages.German;
                UpdateLanguage();
                break;
        }
    }

    void UpdateLanguage()
    {
        languages[currentLanguage].TryGetValue("Name", out languageName);
        //languages[currentLanguage].TryGetValue("Button1", out Button1);
        //languages[currentLanguage].TryGetValue("Button2", out Button2);
        //elem.test.GetComponentInChildren<Text>().text = Button1;
        //elem.bla.GetComponentInChildren<Text>().text = Button2;
    }

    void Reader()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(dictionary.text);
        XmlNodeList languagesList = xmlDoc.GetElementsByTagName("language");

        foreach(XmlNode languageValue in languagesList)
        {
            XmlNodeList languageContent = languageValue.ChildNodes;
            obj = new Dictionary<string, string>();

            foreach(XmlNode value in languageContent)
            {
                obj.Add(value.Name, value.InnerText);
               
                //switch (value.Name)
                //{
                //    case "Name":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //    case "Button1":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //    case "Button2":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //    case "Question1":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //    case "Question2":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //    case "Question3":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //    case "Question4":
                //        obj.Add(value.Name, value.InnerText);
                //        break;
                //} 
            }

            languages.Add(obj);
        }
    }
}
