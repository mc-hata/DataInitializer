using UnityEngine;
using UnityEditor;
using System.Collections;

public class DataInitializer : EditorWindow {

	[MenuItem("DataInitializer/Initialize")]

	static void init(){
		DataInitializer window = (DataInitializer)EditorWindow.GetWindow (typeof(DataInitializer));
	}

	void OnGUI(){

		EditorGUILayout.LabelField ("Initialize MasterData and GameData");

		if(GUILayout.Button("Initialize")){

			AssetDatabase.DeleteAsset("Assets/Resources/MasterData.txt");
			Debug.Log (AssetDatabase.CopyAsset("Assets/StreamingAssets/MasterData.txt","Assets/Resources/MasterData.txt"));
			AssetDatabase.DeleteAsset("Assets/Resources/GameData.txt");
			Debug.Log (AssetDatabase.CopyAsset("Assets/StreamingAssets/GameData.txt","Assets/Resources/GameData.txt"));

		}
	}


}
