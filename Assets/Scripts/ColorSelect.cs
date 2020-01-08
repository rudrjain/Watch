using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelect : MonoBehaviour
{
    public Material band1, band2, band3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1color()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if(buttonName=="BlackButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }

        else if (buttonName == "BlueButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#1243A2", out myColor);
            band1.color = myColor;
        }

    }

    public void w2color()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "BlackButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }

        else if (buttonName == "RedButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;
        }
    }

    public void w3color()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "BlackButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#919191", out myColor);
            band3.color = myColor;
        }

        else if (buttonName == "SilverButton")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#D8DCE7", out myColor);
            band3.color = myColor;
        }
    }
}
