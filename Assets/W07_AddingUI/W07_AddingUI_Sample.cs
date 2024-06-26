using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W07_AddingUI_Sample : MonoBehaviour
{
    public Slider slider;
    public GameObject ObjectToControl;
    Vector3 DefaultPos;
    Quaternion DefaultRot;

    private void Start()
    {
        DefaultPos = ObjectToControl.transform.localPosition;
        DefaultRot = ObjectToControl.transform.rotation;
    }

    public void OnSlide_Rotate()
    {
        float sliderValue = slider.value;
        print(sliderValue);
        ObjectToControl.transform.rotation = Quaternion.Euler(0, sliderValue * 360.0f ,0);
    }

    public void OnClick_MoveLeft()
    {
        print("Move Left");
        ObjectToControl.transform.Translate(Vector3.left * 0.1f);
    }

    public void OnClick_MoveRight()
    {
        print("Move Right");
        ObjectToControl.transform.Translate(Vector3.right * 0.1f);
    }

    public void OnClick_DefaultPos()
    {
        print("Default Pos");
        ObjectToControl.transform.localPosition = DefaultPos;
    }

    public void OnClick_DefaultRot()
    {
        print("Default Rot");
        ObjectToControl.transform.rotation = DefaultRot;
        slider.value = 0.0f;
    }

    public void OnClick_SetActive(bool active)
    {
        print("Set Active");
        ObjectToControl.SetActive(active);
    }
}
