using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContentSizeFitter : MonoBehaviour
{
    public GameObject Content;
    public GameObject MyPrefab;
    int counter = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Clone = Instantiate(MyPrefab);
            Clone.GetComponent<TMP_Text>().text = $"Counter: {counter}";
            counter++;
            Clone.transform.parent = Content.transform;
        }
    }
}
