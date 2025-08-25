using System;
using System.Diagnostics;
using BepInEx;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GorillaPlaytime
{
    [BepInPlugin("ciperuoy.gorillaplaytime", "GorillaPlaytime", "1.0.2")]
    public class Plugin : BaseUnityPlugin
    {
        private Stopwatch _watch;
        private bool _showGui = true;
        private string _timeElapsed = "";

        private void Awake()
        {
            _watch = new Stopwatch();
            _watch.Start();
        }

        private void Update()
        {
            _timeElapsed = _watch.Elapsed.ToString(@"hh\:mm\:ss");
            if (UnityInput.Current.GetKeyDown(KeyCode.Tab))
            {
                _showGui = !_showGui;
            }
        }

        private void OnGUI()
        {
            if (_showGui)
                GUI.Label(new Rect(10, 10, 200, 20), $"Playtime: {_timeElapsed}");
        }
    }
}

