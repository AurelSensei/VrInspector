using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerTest : MonoBehaviour
{
    public PanelTest  currentPanel = null;

    private List<PanelTest> panelHistory = new List<PanelTest>();

    private void Start()
    {
        SetupPanels();
    }

    private void SetupPanels()
    {
        PanelTest[] panels = GetComponentsInChildren<PanelTest>();

        foreach (PanelTest panel in panels)
            panel.Setup(this);

        currentPanel.Show();
    }

/*    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) || OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
            GoToPrevious();
    }*/

    public void GoToPrevious()
    {
        if(panelHistory.Count == 0)
        {
            OVRManager.PlatformUIConfirmQuit();
            return;
        }

        int lastIndex = panelHistory.Count - 1;
        SetCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);
    }

    public void SetCurrentWithHistory(PanelTest newPanel)
    {
        panelHistory.Add(currentPanel);
        SetCurrent(newPanel);
    }

    public void SetCurrent(PanelTest newPanel)
    {
        currentPanel.Hide();

        currentPanel = newPanel;
        currentPanel.Show();
    }

    public void AppQuit()
    {
        OVRManager.PlatformUIConfirmQuit();
        return;
    }

    public void TpToMenu()
    {
        SceneManager.LoadScene("Lobby");
    }
}
