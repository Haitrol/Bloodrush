using UnityEditor;
using UnityEngine;

public class MassUpgradeEditor : EditorWindow {

    [MenuItem("Window/Mass Upgrade Editor")]
    static void Init()
    {
        MassUpgradeEditor creator = (MassUpgradeEditor)GetWindow(typeof(MassUpgradeEditor));
        creator.minSize = new Vector2(500, 300);
        creator.Show();
    }

    void OnGUI()
    {
        if (GUILayout.Button("Refresh"))
        {
            object[] upgrades = GameObject.FindGameObjectsWithTag("UpgradeButton");
            Debug.Log(upgrades.Length);

            foreach (object upgrade in upgrades)
            {
                GameObject up = (GameObject)upgrade;
                //up = GUILayout.Label("Upgrade Name", EditorStyles.boldLabel);
            }
        }
    }
}
