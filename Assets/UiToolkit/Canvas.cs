using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Canvas : MonoBehaviour
{

    UIDocument screenPlayer;
    VisualElement image1;
    VisualElement image2;
    VisualElement image3;

    Button buttonPause;
    Button buttonPlay;

    private void OnEnable()
    {
        screenPlayer = GetComponent<UIDocument>();
        VisualElement root = screenPlayer.rootVisualElement;

        image1 = root.Q<VisualElement>("HealthBar1");
        image2 = root.Q<VisualElement>("HealthBar2");
        image3 = root.Q<VisualElement>("HealthBar3");

        image3.style.display = DisplayStyle.Flex;

        buttonPause = root.Q<Button>("ButtonPausa") as Button;
        buttonPause.RegisterCallback<ClickEvent>(OnButtonClickPausa);

        buttonPlay = root.Q<Button>("ButtonPlay") as Button;
        buttonPlay.RegisterCallback<ClickEvent>(OnButtonClickPlay);

    }

    public void OnButtonClickPausa(ClickEvent evt){
        Time.timeScale = 0f;
        buttonPause.style.display = DisplayStyle.None;
        buttonPlay.style.display = DisplayStyle.Flex;
    }

    public void OnButtonClickPlay(ClickEvent evt){
        Time.timeScale = 1f;
        buttonPause.style.display = DisplayStyle.Flex;
        buttonPlay.style.display = DisplayStyle.None;
    }

    public void TakeLife(int health)
    {
        switch (health)
        {
            case 3:
                image3.style.display = DisplayStyle.Flex;
                image2.style.display = DisplayStyle.None;
                image1.style.display = DisplayStyle.None;
                break;
            case 2:
                image3.style.display = DisplayStyle.None;
                image2.style.display = DisplayStyle.Flex;
                image1.style.display = DisplayStyle.None;
                break;
            case 1:
                image3.style.display = DisplayStyle.None;
                image2.style.display = DisplayStyle.None;
                image1.style.display = DisplayStyle.Flex;
                break;
        }
    }

}
