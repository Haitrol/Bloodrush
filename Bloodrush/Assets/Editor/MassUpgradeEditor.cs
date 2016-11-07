using UnityEditor;
using UnityEngine;

public class MassUpgradeEditor : EditorWindow {
    
    //SerializedObject upgr;
    //SerializedProperty bpm, mult, cal, cost;
    //GameObject[] upgrades;

    //[MenuItem("Window/Mass Upgrade Editor")]
    //static void Init()
    //{
    //    MassUpgradeEditor creator = (MassUpgradeEditor)GetWindow(typeof(MassUpgradeEditor));
    //    creator.minSize = new Vector2(500, 300);
    //    creator.Show();

    //}

    //void OnGUI()
    //{
    //    upgrades = GameObject.FindGameObjectsWithTag("UpgradeButton");

    //    if (upgrades.Length >= 1)
    //    {
    //        foreach (var upgrade in upgrades)
    //        {
    //            Upgrade up = upgrade.GetComponent<Upgrade>();
    //            GUILayout.Label(upgrade.name);
                
    //            upgr = new SerializedObject(upgrade);

    //            //bpm = upgr.FindProperty("BPMIncrease");
    //            mult = upgr.FindProperty("multiplierIncrease");
    //            cost = upgr.FindProperty("cost");

    //            //EditorGUILayout.PropertyField(bpm);
    //            EditorGUILayout.PropertyField(mult);
    //            EditorGUILayout.PropertyField(cost);
                
    //        }
    //    }
    //}
}
