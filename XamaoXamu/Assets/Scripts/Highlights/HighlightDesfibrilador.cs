using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightDesfibrilador : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite DesfibriladorHighlight;
    public Sprite Desfibrilador;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().sprite = DesfibriladorHighlight;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Desfibrilador;
    }
}
