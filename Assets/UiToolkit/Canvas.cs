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

    Button button;

    private void OnEnable()
    {
        screenPlayer = GetComponent<UIDocument>();
        VisualElement root = screenPlayer.rootVisualElement;

        image1 = root.Q<VisualElement>("HealthBar1");
        image2 = root.Q<VisualElement>("HealthBar2");
        image3 = root.Q<VisualElement>("HealthBar3");

        image3.style.display = DisplayStyle.Flex;

        button = root.Q<Button>("ButtonPausa");
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
