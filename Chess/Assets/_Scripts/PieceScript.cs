using UnityEngine;

public class PieceScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private abstract class Piece
    {
        // clicking it will reveal all the locations it can go, hides if clicked again
            // probably better for it to generate and delete instead of being active all the time

        // clicking on the location will enable it to go to said location, but only if it is the player's turn


    }

    private class Pawn : Piece
    {
        bool canEnPassant;
        // first time moving the piece will allow it to move twice
            // check sides to see if enemy pawn is next to it, if so flip bool for en passant for the pieces that can
    }
}
