using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retical : MonoBehaviour
{

    private RectTransform crosshair;

    [Range(50f, 250)]
    public float size;
    
    
    private void Start()
    {
        crosshair = GetComponent<RectTransform>();
    }



    private void Update()
    {
        crosshair.sizeDelta = new Vector2(size, size);
    }
}
