using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    RectTransform rect;
    // Start is called before the first frame update
    void Awake()
    {
        rect = GetComponent<RectTransform>();
        
    }

    void FixedUpdate()
    {
        rect.position = Camera.main.WorldToScreenPoint
            (GameManager.Instance.player.transform.position);
    }

}