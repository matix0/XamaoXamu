using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightGases : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite GasesHighlight;
    public Sprite Gases;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().sprite = GasesHighlight;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Gases;
    }
}
