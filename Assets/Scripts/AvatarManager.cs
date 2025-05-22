using UnityEngine;
using UnityEngine.UI;

public class AvatarManager : MonoBehaviour
{
    public GameObject peerPanel;
    public GameObject teacherPanel;
    public GameObject parentPanel;

    public Button peerButton;
    public Button teacherButton;
    public Button parentButton;

    void Start()
    {
        HideAllPanels();

        peerButton.onClick.AddListener(() => ShowPanel("Peer"));
        teacherButton.onClick.AddListener(() => ShowPanel("Teacher"));
        parentButton.onClick.AddListener(() => ShowPanel("Parent"));
    }

    void HideAllPanels()
    {
        peerPanel.SetActive(false);
        teacherPanel.SetActive(false);
        parentPanel.SetActive(false);
    }

    void ShowPanel(string role)
    {
        HideAllPanels();

        switch (role)
        {
            case "Peer":
                peerPanel.SetActive(true);
                break;
            case "Teacher":
                teacherPanel.SetActive(true);
                break;
            case "Parent":
                parentPanel.SetActive(true);
                break;
        }
    }
}
