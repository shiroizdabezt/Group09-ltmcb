using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class Chessman : MonoBehaviour
{
    public bool hasMoved = false;

    //References to objects in our Unity Scene
    public GameObject controller;
    public GameObject movePlate;

    //Position for this Chesspiece on the Board
    //The correct position will be set later
    private int xBoard = -1;
    private int yBoard = -1;

    //Variable for keeping track of the player it belongs to "black" or "white"
    private string player;

    //References to all the possible Sprites that this Chesspiece could be
    public Sprite black_queen, black_knight, black_bishop, black_king, black_rook, black_pawn;
    public Sprite white_queen, white_knight, white_bishop, white_king, white_rook, white_pawn;

    public void Activate()
    {
        //Get the game controller
        controller = GameObject.FindGameObjectWithTag("GameController");

        //Take the instantiated location and adjust transform
        SetCoords();

        //Choose correct sprite based on piece's name
        switch (this.name)
        {
            case "black_queen": this.GetComponent<SpriteRenderer>().sprite = black_queen; player = "black"; break;
            case "black_knight": this.GetComponent<SpriteRenderer>().sprite = black_knight; player = "black"; break;
            case "black_bishop": this.GetComponent<SpriteRenderer>().sprite = black_bishop; player = "black"; break;
            case "black_king": this.GetComponent<SpriteRenderer>().sprite = black_king; player = "black"; break;
            case "black_rook": this.GetComponent<SpriteRenderer>().sprite = black_rook; player = "black"; break;
            case "black_pawn": this.GetComponent<SpriteRenderer>().sprite = black_pawn; player = "black"; break;
            case "white_queen": this.GetComponent<SpriteRenderer>().sprite = white_queen; player = "white"; break;
            case "white_knight": this.GetComponent<SpriteRenderer>().sprite = white_knight; player = "white"; break;
            case "white_bishop": this.GetComponent<SpriteRenderer>().sprite = white_bishop; player = "white"; break;
            case "white_king": this.GetComponent<SpriteRenderer>().sprite = white_king; player = "white"; break;
            case "white_rook": this.GetComponent<SpriteRenderer>().sprite = white_rook; player = "white"; break;
            case "white_pawn": this.GetComponent<SpriteRenderer>().sprite = white_pawn; player = "white"; break;
        }
    }

    public void SetCoords()
    {
        //Get the board value in order to convert to xy coords
        float x = xBoard;
        float y = yBoard;

        //Adjust by variable offset
        //x *= 0.66f;
        //y *= 0.66f;

        //Add constants (pos 0,0)
        x += -3.5f;
        y += -3.5f;

        //Set actual unity values
        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }

    private void OnMouseUp()
    {
        if (!controller.GetComponent<Game>().IsGameOver() && controller.GetComponent<Game>().GetCurrentPlayer() == player)
        {
            //Remove all moveplates relating to previously selected piece
            DestroyMovePlates();

            //Create new MovePlates
            InitiateMovePlates();
        }
    }

    public void DestroyMovePlates()
    {
        //Destroy old MovePlates
        GameObject[] movePlates = GameObject.FindGameObjectsWithTag("MovePlate");
        for (int i = 0; i < movePlates.Length; i++)
        {
            Destroy(movePlates[i]); //Be careful with this function "Destroy" it is asynchronous
        }
    }

    public void InitiateMovePlates()
    {
        switch (this.name)
        {
            case "black_queen":
            case "white_queen":
                LineMovePlate(1, 0);
                LineMovePlate(0, 1);
                LineMovePlate(1, 1);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                LineMovePlate(-1, -1);
                LineMovePlate(-1, 1);
                LineMovePlate(1, -1);
                break;
            case "black_knight":
            case "white_knight":
                LMovePlate();
                break;
            case "black_bishop":
            case "white_bishop":
                LineMovePlate(1, 1);
                LineMovePlate(1, -1);
                LineMovePlate(-1, 1);
                LineMovePlate(-1, -1);
                break;
            case "black_king":
            case "white_king":
                SurroundMovePlate();
                break;
            case "black_rook":
            case "white_rook":
                LineMovePlate(1, 0);
                LineMovePlate(0, 1);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                break;
            case "black_pawn":
                PawnMovePlate(xBoard, yBoard - 1);
                if (!hasMoved) PawnMoveTwo(xBoard, yBoard-2);
                break;
            case "white_pawn":
                PawnMovePlate(xBoard, yBoard + 1);
                if (!hasMoved) PawnMoveTwo(xBoard, yBoard+2);
                break;
        }
    }

    public void LineMovePlate(int xIncrement, int yIncrement)
    {
        Game sc = controller.GetComponent<Game>();

        int x = xBoard + xIncrement;
        int y = yBoard + yIncrement;

        while (sc.PositionOnBoard(x, y) && sc.GetPosition(x, y) == null)
        {
            MovePlateSpawn(x, y);
            x += xIncrement;
            y += yIncrement;
        }

        if (sc.PositionOnBoard(x, y) && sc.GetPosition(x, y).GetComponent<Chessman>().player != player)
        {
            MovePlateAttackSpawn(x, y);
        }
    }

    public void LMovePlate()
    {
        PointMovePlate(xBoard + 1, yBoard + 2);
        PointMovePlate(xBoard - 1, yBoard + 2);
        PointMovePlate(xBoard + 2, yBoard + 1);
        PointMovePlate(xBoard + 2, yBoard - 1);
        PointMovePlate(xBoard + 1, yBoard - 2);
        PointMovePlate(xBoard - 1, yBoard - 2);
        PointMovePlate(xBoard - 2, yBoard + 1);
        PointMovePlate(xBoard - 2, yBoard - 1);
    }

    public void SurroundMovePlate()
    {
        PointMovePlate(xBoard, yBoard + 1);
        PointMovePlate(xBoard, yBoard - 1);
        PointMovePlate(xBoard - 1, yBoard + 0);
        PointMovePlate(xBoard - 1, yBoard - 1);
        PointMovePlate(xBoard - 1, yBoard + 1);
        PointMovePlate(xBoard + 1, yBoard + 0);
        PointMovePlate(xBoard + 1, yBoard - 1);
        PointMovePlate(xBoard + 1, yBoard + 1);
    }

    public void PointMovePlate(int x, int y)
    {
        Game sc = controller.GetComponent<Game>();
        if (sc.PositionOnBoard(x, y))
        {
            GameObject cp = sc.GetPosition(x, y);

            if (cp == null)
            {
                MovePlateSpawn(x, y);
            }
            else if (cp.GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x, y);
            }
        }
    }

    public void PawnMovePlate(int x, int y)
    {
        Game sc = controller.GetComponent<Game>();
        if (sc.PositionOnBoard(x, y))
        {
            if (sc.GetPosition(x, y) == null)
            {
                MovePlateSpawn(x, y);
            }

            if (sc.PositionOnBoard(x + 1, y) && sc.GetPosition(x + 1, y) != null && sc.GetPosition(x + 1, y).GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x + 1, y);
            }

            if (sc.PositionOnBoard(x - 1, y) && sc.GetPosition(x - 1, y) != null && sc.GetPosition(x - 1, y).GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x - 1, y);
            }
        }
    }

    public void PawnMoveTwo( int x, int y)
    {
        Game sc = controller.GetComponent<Game>();
        if (player == "black")
        {
            if (sc.PositionOnBoard(x, y) && sc.GetPosition(x, y) == null && sc.GetPosition(x, y + 1) == null)
            {
                MovePlateSpawn(x, y);
            }

            else if (sc.PositionOnBoard(x, y) && sc.GetPosition(x, y) == null && sc.GetPosition(x, y + 1) != null)
            {
                
            }

            if (sc.PositionOnBoard(x, y) && sc.GetPosition(x + 1, y + 1) != null && sc.GetPosition(x + 1, y + 1).GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x + 1, y + 1);
            }

            if (sc.PositionOnBoard(x, y) && sc.GetPosition(x - 1, y + 1) != null && sc.GetPosition(x - 1, y + 1).GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x - 1, y + 1);
            }
        }
        else
        {
            if (sc.PositionOnBoard(x, y) && sc.GetPosition(x, y) == null && sc.GetPosition(x, y - 1) == null)
            {
                MovePlateSpawn(x, y);
            }

            else if (sc.PositionOnBoard(x, y) && sc.GetPosition(x, y) == null && sc.GetPosition(x, y - 1) != null)
            {

            }

            if (sc.PositionOnBoard(x, y) && sc.GetPosition(x + 1, y - 1) != null && sc.GetPosition(x + 1, y - 1).GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x + 1, y - 1);
            }

            if (sc.PositionOnBoard(x, y) && sc.GetPosition(x - 1, y - 1) != null && sc.GetPosition(x - 1, y - 1).GetComponent<Chessman>().player != player)
            {
                MovePlateAttackSpawn(x - 1, y - 1);
            }
        }    
    }

    public void MovePlateSpawn(int matrixX, int matrixY)
    {
        //Get the board value in order to convert to xy coords
        float x = matrixX;
        float y = matrixY;

        //Adjust by variable offset
        //x *= 0.66f;
        //y *= 0.66f;

        //Add constants (pos 0,0)
        x += -3.5f;
        y += -3.5f;

        //Set actual unity values
        GameObject mp = Instantiate(movePlate, new Vector3(x, y, -3.0f), Quaternion.identity);

        MovePlate mpScript = mp.GetComponent<MovePlate>();
        mpScript.SetReference(gameObject);
        mpScript.SetCoords(matrixX, matrixY);
    }

    public void MovePlateAttackSpawn(int matrixX, int matrixY)
    {
        //Get the board value in order to convert to xy coords
        float x = matrixX;
        float y = matrixY;

        //Adjust by variable offset
        //x *= 0.66f;
        //y *= 0.66f;

        //Add constants (pos 0,0)
        x += -3.5f;
        y += -3.5f;

        //Set actual unity values
        GameObject mp = Instantiate(movePlate, new Vector3(x, y, -3.0f), Quaternion.identity);

        MovePlate mpScript = mp.GetComponent<MovePlate>();
        mpScript.attack = true;
        mpScript.SetReference(gameObject);
        mpScript.SetCoords(matrixX, matrixY);
    }

    void Update()
    {
        switch (this.name)
        {
            case "black_pawn":
                if (yBoard == 0)
                {

                    GameObject cp = controller.GetComponent<Game>().GetPosition(xBoard, yBoard);
                    cp.name = "black_queen";
                    this.GetComponent<SpriteRenderer>().sprite = black_queen; player = "black";

                }
                break;

            case "white_pawn":
                if (yBoard == 7)
                {
                    GameObject cp = controller.GetComponent<Game>().GetPosition(xBoard, yBoard);
                    cp.name = "white_queen";
                    this.GetComponent<SpriteRenderer>().sprite = white_queen; player = "white";

                }
                break;
            //case "black_king":
            //    int x1 = xBoard;
            //    int y1 = yBoard;
                
            //    if (hasMoved == false)
            //    {
            //        if (IsNullBetweenBlackRookAndKing(x1, y1))
            //        {
            //            PointMovePlate(x1 + 2, y1);
            //        }    
            //    }
            //    break;
        }
    }
    //public bool IsNullBetweenBlackRookAndKing(int x, int y)
    //{
    //    Game sc = controller.GetComponent<Game>();
    //    GameObject blackRook = GameObject.Find("black_rook");
    //    Vector3 blr = blackRook.transform.position;
    //    float x2 = blr.x;
    //    float y2 = blr.y;
    //    {
    //        if (x2 < x)
    //        {
    //            int a = 0;
    //            for (int i = (int)x2 +1; i< x; i++)
    //            {
    //                if (sc.GetPosition(i, yBoard) == null) a++;
    //                if (a == (x- x2)) return true;
    //            }
    //        }
    //    }
    //    return false;
    //}    
}
