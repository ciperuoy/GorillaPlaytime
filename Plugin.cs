using System;
using System.Diagnostics;
using BepInEx;
using UnityEngine;
using Utilla;

namespace GorillaPlaytime
{
    [BepInPlugin("ciperuoy.gorillaplaytime", "GorillaPlaytime", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public string TimeElapsed = "";
        Stopwatch watch = new Stopwatch();
        public void Awake() => 
            watch.Start();
       
        public void Update() =>
            TimeElapsed = watch.Elapsed.ToString(@"hh\:mm\:ss");

        public void OnGUI() => 
            GUI.Label(new Rect(10, 10, 200, 20), TimeElapsed);
    }
}
