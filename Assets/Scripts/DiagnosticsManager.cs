using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class DiagnosticsManager
{
    [Inject]
    private UIManager uiManager = null;

    public void Status()
    {
        Debug.Log($"{nameof(SetupInstaller)} is running & Zenject is configured");
        Debug.Log($"{nameof(DiagnosticsManager)} has been instantiated as a singleton");

        uiManager.Display($"{nameof(SetupInstaller)} is running & Zenject is configured", 
        $"{nameof(DiagnosticsManager)} has been instantiated as a singleton");
    }
}
