using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class GenerateUIHierarchy : MonoBehaviour
{
    [MenuItem("Tools/Generate UI Setup")]
    public static void GenerateUI()
    {
        // Create Canvas
        GameObject canvasGO = new GameObject("Canvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
        Canvas canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Create EventSystem
        new GameObject("EventSystem", typeof(UnityEngine.EventSystems.EventSystem), typeof(UnityEngine.EventSystems.StandaloneInputModule));

        // Helper to create a button
        void CreateUIButton(string name)
        {
            GameObject buttonGO = new GameObject(name, typeof(RectTransform), typeof(CanvasRenderer), typeof(Button), typeof(Image));
            buttonGO.transform.SetParent(canvasGO.transform, false);
            buttonGO.GetComponentInChildren<RectTransform>().sizeDelta = new Vector2(160, 30);
        }

        // Helper to create a panel
        void CreatePanel(string name)
        {
            GameObject panelGO = new GameObject(name, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
            panelGO.transform.SetParent(canvasGO.transform, false);
            panelGO.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 200);
        }

        // Buttons
        CreateUIButton("PeerButton");
        CreateUIButton("TeacherButton");
        CreateUIButton("ParentButton");

        // Panels
        CreatePanel("PeerPanel");
        CreatePanel("TeacherPanel");
        CreatePanel("ParentPanel");

        Debug.Log("✅ UI Created in Scene");
    }
}
