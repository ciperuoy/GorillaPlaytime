using System.Diagnostics;
using BepInEx;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GorillaPlaytime
{
    [BepInPlugin("ciperuoy.gorillaplaytime", "GorillaPlaytime", "1.0.1")]
    public class Plugin : BaseUnityPlugin
    {
        Stopwatch watch = new Stopwatch();
        public bool gui = true;
        public string TimeElapsed = "";

        public void Awake() => 
            watch.Start();
       
        public void Update()
        {
            TimeElapsed = watch.Elapsed.ToString(@"hh\:mm\:ss");

            if (Keyboard.current.tabKey.wasPressedThisFrame)
                gui = !gui;
        }

        public void OnGUI()
        {
            if (gui)
                GUI.Label(new Rect(10, 10, 200, 20), TimeElapsed);
        }
    }
}
