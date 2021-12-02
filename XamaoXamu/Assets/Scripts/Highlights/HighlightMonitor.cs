using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightMonitor : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite MonitorHighlight;
    public Sprite Monitor;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().sprite = MonitorHighlight;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Monitor;
    }
}
