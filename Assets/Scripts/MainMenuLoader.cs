using UnityEngine;
using UnityEngine.UI;

public class MainMenuLoader : MonoBehaviour
{
    public Canvas canvas;
    public Sprite backgroundSprite;
    public Sprite chameleonSprite;
    public Sprite scienceLabSprite;
    public Sprite mathGardenSprite;
    public Sprite techWorkshopSprite;
    public Sprite xpBarSprite;

    void Start()
    {
        CreateBackground();
        CreateXPBar();
        CreateChameleonWithSpeech();
        CreateButtons();
    }

    void CreateBackground()
    {
        GameObject bg = new GameObject("Background");
        Image img = bg.AddComponent<Image>();
        img.sprite = backgroundSprite;
        bg.transform.SetParent(canvas.transform, false);
        img.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
    }

    void CreateXPBar()
    {
        GameObject xp = new GameObject("XPBar");
        Image xpImage = xp.AddComponent<Image>();
        xpImage.sprite = xpBarSprite;
        xp.transform.SetParent(canvas.transform, false);
        xpImage.rectTransform.anchoredPosition = new Vector2(0, Screen.height / 2 - 60);
    }

    void CreateChameleonWithSpeech()
    {
        GameObject chameleon = new GameObject("Chameleon");
        Image chameleonImg = chameleon.AddComponent<Image>();
        chameleonImg.sprite = chameleonSprite;
        chameleon.transform.SetParent(canvas.transform, false);
        chameleonImg.rectTransform.anchoredPosition = new Vector2(0, -100);

        GameObject speech = new GameObject("SpeechBubble");
        Text speechText = speech.AddComponent<Text>();
        speechText.text = "Try the next science station!";
        speechText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        speechText.alignment = TextAnchor.MiddleCenter;
        speechText.color = Color.black;
        speech.transform.SetParent(canvas.transform, false);
        speechText.rectTransform.anchoredPosition = new Vector2(0, 50);
    }

    void CreateButtons()
    {
        CreateStationButton("Math Garden", new Vector2(-300, -200), mathGardenSprite);
        CreateStationButton("Science Lab", new Vector2(200, -50), scienceLabSprite);
        CreateStationButton("Tech Workshop", new Vector2(250, -250), techWorkshopSprite);
    }

    void CreateStationButton(string label, Vector2 position, Sprite sprite)
    {
        GameObject btnObj = new GameObject(label);
        Button btn = btnObj.AddComponent<Button>();
        Image img = btnObj.AddComponent<Image>();
        img.sprite = sprite;
        btnObj.transform.SetParent(canvas.transform, false);
        img.rectTransform.anchoredPosition = position;
        img.rectTransform.sizeDelta = new Vector2(160, 160);

        GameObject txtObj = new GameObject(label + "_Text");
        Text txt = txtObj.AddComponent<Text>();
        txt.text = label;
        txt.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        txt.alignment = TextAnchor.MiddleCenter;
        txt.color = Color.white;
        txtObj.transform.SetParent(btnObj.transform, false);
        txt.rectTransform.anchoredPosition = Vector2.zero;
        txt.rectTransform.sizeDelta = new Vector2(160, 30);
    }
}
