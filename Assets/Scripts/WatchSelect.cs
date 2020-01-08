using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    public GameObject watch1, watch2, watch3;
    public GameObject w1, w2, w3;
    Animation window1, window2, window3;

    // Start is called before the first frame update
    void Start()
    {
        window1 = w1.GetComponent<Animation>();
        window2 = w2.GetComponent<Animation>();
        window3 = w3.GetComponent<Animation>();

    }

    public void w1click()
    {
        watch1.SetActive(true);
        watch2.SetActive(false);
        watch3.SetActive(false);

        window1["W1"].speed = 1;
        window1.Play();
    }
    public void w2click()
    {
        watch1.SetActive(false);
        watch2.SetActive(true);
        watch3.SetActive(false);

        window2["W2"].speed = 1;
        window2.Play();
    }
    public void w3click()
    {
        watch1.SetActive(false);
        watch2.SetActive(false);
        watch3.SetActive(true);

        window3["W3"].speed = 1;
        window3.Play();
    }

    public void close()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName=="w1close")
        {
            window1["W1"].speed = -1;
            window1["W1"].time = window1["W1"].length;
            window1.Play();
        }

        if (buttonName == "w2close")
        {
            window2["W2"].speed = -1;
            window2["W2"].time = window2["W2"].length;
            window2.Play();
        }

        if (buttonName == "w3close")
        {
            window3["W3"].speed = -1;
            window3["W3"].time = window3["W3"].length;
            window3.Play();
        }
    }
}
