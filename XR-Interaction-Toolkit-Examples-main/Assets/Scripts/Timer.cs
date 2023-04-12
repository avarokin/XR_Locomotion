using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float stopTime;
    float currentTime = 0f;
    public TextMeshProUGUI textField;
    bool pressedStart = false;
    bool pressed1 = false;
    bool pressed2 = false;
    bool pressed3 = false;
    bool pressed4 = false;
    bool pressed5 = false;
    bool pressed6 = false;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void OnPressStart()
    {
        pressedStart = true;
    }

    public void OnPress1()
    {
        pressed1 = true;
    }

    public void OnPress2()
    {
        pressed2 = true;
    }

    public void OnPress3()
    {
        pressed3 = true;
    }

    public void OnPress4()
    {
        pressed4 = true;
    }

    public void OnPress5()
    {
        pressed5 = true;
    }

    public void OnPress6()
    {
        pressed6 = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (buttonPress) {
            // update current time
        //}

        if (pressedStart && pressed1
            && pressed2 && pressed3
            && pressed4 && pressed5
            && pressed6)
        {
            pressedStart = false;
            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
            pressed5 = false;
            pressed6 = false;
            stopTime = currentTime;
            currentTime = 0f;
            textField.text = stopTime.ToString() + " s";
        }

        if (pressedStart) {
            currentTime += Time.deltaTime;
            textField.text = currentTime.ToString() + " s";
        }
    }
}
