using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightBomba : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite BombaHighlight;
    public Sprite Bomba;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().sprite = BombaHighlight;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Bomba;
    }
}
