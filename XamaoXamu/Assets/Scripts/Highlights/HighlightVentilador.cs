using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightVentilador : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite VentiladorHighlight;
    public Sprite Ventilador;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().sprite = VentiladorHighlight;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Ventilador;
    }
}
