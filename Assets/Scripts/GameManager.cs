using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class GameManager : MonoBehaviour
{
    /* UI Bindings */
    [SerializeField]
    private Text debugText = null;

    /* Instances in this method get injected by Zenject
     * and it is assumed they were configured in SetupInstaller.cs 
     */
    [Inject]
    public void Setup(DiagnosticsManager diagnosticsManager, UIManager uiManager) 
    {
        uiManager.BindUI(debugText);
        diagnosticsManager.Status();
    }
}
