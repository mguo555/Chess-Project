using UnityEngine;

public class GridSquareScript : MonoBehaviour
{
    // each square of the board will be assigned a name
    public string name;
    private Color color;
    public GameObject borderHighlight;

    public GridSquareScript(string squareName, Color origColor)
    {
        name = squareName;
        color = origColor;
        gameObject.GetComponent<SpriteRenderer>().color = color;
        
        // creates another gameObject the same size of the grid square to use as a highlight
        borderHighlight = new GameObject(squareName + " highlight");
        SpriteRenderer sr = borderHighlight.AddComponent<SpriteRenderer>();
        sr.sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }
    
    // lightens / darkens, use when highlighting where a piece can move
        // if the piece is white, color of the square should darken & highlight should lighten
            // vice versa if the piece is black
        // also happens like a highlight when the cursor is hovering over a piece
    // TODO: Make this into an animation, preferably expanding outwards from the piece
    // TODO: Define black and white as a color that can be modified via Unity
    public void highlightSquare(bool isWhite)
    {
        if (isWhite)
        {
            borderHighlight.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        }
        else
        {
            borderHighlight.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        }
        gameObject.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
    }
    
    // reverts square colors to original state
    public void revertHighlight()
    {
        
    }
    

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
