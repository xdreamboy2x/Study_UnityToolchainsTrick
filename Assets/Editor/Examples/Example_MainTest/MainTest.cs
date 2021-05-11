using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

public class MainTest : MonoBehaviour
{
    [MenuItem("Tools/MainTest")]
    public static void Pack()
    {
        Rect wr = new Rect(300, 400, 400, 100);
        MainTestWindow window = (MainTestWindow)EditorWindow.GetWindowWithRect(typeof(MainTestWindow), wr, true, "查找项目中的中文字符");
        window.Show();
    }
}

public class MainTestWindow : EditorWindow
{
    
    public void OnGUI()
    { 
        EditorGUILayout.BeginHorizontal(); 
        if (GUILayout.Button("开始遍历项目"))
        {
            
        }

        EditorGUILayout.EndHorizontal();
    } 
}