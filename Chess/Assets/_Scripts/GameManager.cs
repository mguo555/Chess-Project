using UnityEngine;

public class GameManager : MonoBehaviour
{
    // keeps a track of whose move it is, list of moves, material captured (as well as points), time, etc.
    BoardManager board = GameObject.FindAnyObjectByType<BoardManager>();
    
    void startGame()
    {
        board.standardStart();
    }

}
