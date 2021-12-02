using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightCarrinho : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite CarrinhoHighlight;
    public Sprite Carrinho;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnMouseEnter()
    {
        transform.GetComponent<SpriteRenderer>().sprite = CarrinhoHighlight;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Carrinho;
    }
}
