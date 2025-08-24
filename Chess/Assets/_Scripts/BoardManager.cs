using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public GameObject lightPrefab;
    public GameObject darkPrefab;

    private int boardSize;
    void Start()
    {
        // maybe change boardSize for variants?
        boardSize = 8;

        // initialize board
        createBoard();
    }

    // have GameManager call this function later
    public void standardStart()
    {
        boardSize = 8;
        createBoard();
    }

    // initializes an 8x8 board with alternating colors
    void createBoard()
    {
        // gets prefab square size from lightPrefab
        float size = lightPrefab.GetComponent<Transform>().localScale.x;

        // creates the grid
        GameObject prefab = new GameObject();
        
        // current board size is 25
        char[] cols = new char[25]{'a', 'b', 'c', 'd', 'e', 'f', 'g',  'h', 'i', 'j', 'k', 'l', 'm', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};;
        for (int row = 0; row < boardSize; row ++)
        {
            for (int col = 0; col < boardSize; col ++)
            {

                if (row % 2 == 0)
                {
                    if (col % 2 == 0)
                    {
                        prefab = darkPrefab;
                    }
                    else
                    {
                        prefab = lightPrefab;
                    }
                    
                }
                else
                {
                    if (col % 2 == 0)
                    {
                        prefab = lightPrefab;
                    }
                    else
                    {
                        prefab = darkPrefab;
                    }
                }
                
                // get square name
                string squareName = cols[col] + (row + 1).ToString();
                
                GameObject.Instantiate(prefab, new Vector3(row - 3.5f * size, col - 3.5f * size, 0), Quaternion.identity);
            }      
        }
    }

    // instantiate pieces



    // Update is called once per frame
    void Update()
    {
        
    }
}
