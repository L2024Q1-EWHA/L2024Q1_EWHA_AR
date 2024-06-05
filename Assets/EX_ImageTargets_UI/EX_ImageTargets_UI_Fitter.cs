using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EX_ImageTargets_UI_Fitter : MonoBehaviour
{
    public GameObject MyPrefab;
    public GameObject Content;
    int counter = 0;

    private void OnMouseDown()
    {
        print("mouse down");
        GameObject Clone = Instantiate(MyPrefab);
        Clone.GetComponent<TMP_Text>().text = $"Counter: {counter}";
        counter++;
        Clone.transform.SetParent(Content.transform);
    }
}
