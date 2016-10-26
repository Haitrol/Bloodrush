using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCreator : EditorWindow
{
    int index = 0;
    string upgradeName = "UpgradeName";

    string[] options = new string[]
    {
        "Heart Upgrade(BPM)", "Blood Cells(Multiplier)", "Muscles(Calories)"
    };

    [MenuItem("Window/Upgrade Creator")]
    static void Init()
    {
        UpgradeCreator creator = (UpgradeCreator)GetWindow(typeof(UpgradeCreator));
        creator.minSize = new Vector2(500, 300);
        creator.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Upgrade Name", EditorStyles.boldLabel);
        upgradeName = EditorGUILayout.TextField(upgradeName);
        GUILayout.Label("Upgrade Type", EditorStyles.boldLabel);
        index = EditorGUILayout.Popup(index, options);

        GUILayout.Label("Make sure you have selected a Canvas in the Inspector!");
        if (GUILayout.Button("Create!"))
        {
            switch(index)
            {
                case 0:
                    CreateBuyButton(upgradeName, "BCUpgradeButton");
                    break;
                case 1:
                    CreateBuyButton(upgradeName, "BPMUpgradeButton");
                    break;
                case 2:
                    Debug.Log("Not defined");
                    break;
            }
        }
    }
    
    static void CreateBuyButton(string mName, string prefabName)
    {
        string name = mName;

        GameObject selected = Selection.activeObject as GameObject;
        if (!selected || selected.name.Length < 1 || !selected.GetComponent<Canvas>())
         {
            Debug.Log("Selected object not a Canvas");
            return;
        }

        GameObject upgrade = Instantiate(Resources.Load("Prefabs/" + prefabName) as GameObject);
        upgrade.GetComponentInChildren<Text>().text = name;
        upgrade.name = name;
        upgrade.transform.SetParent(selected.transform, false);
    }
}