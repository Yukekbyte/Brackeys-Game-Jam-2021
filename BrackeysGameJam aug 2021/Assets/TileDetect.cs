using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDetect : MonoBehaviour
{
    Collider2D currentTile;
    Collider2D leftTile;
    Collider2D rightTile;
    Collider2D upTile;
    Collider2D downTile;
    public PlayerMovement mov;

    //This fuction should get called every time the player ARRIVES at a new tile
    public void UpdateTiles()
    {
        //Reset movement restrictions
        mov.goleft = true;
        mov.goright = true;
        mov.goup = true;
        mov.godown = true;

        //Detect adjecent tiles

        currentTile = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y));// Current point
        leftTile = Physics2D.OverlapPoint(new Vector2(transform.position.x - 1, transform.position.y));// Left point
        rightTile = Physics2D.OverlapPoint(new Vector2(transform.position.x + 1, transform.position.y));// Right point
        upTile = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y + 1));// Up point
        downTile = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y - 1));// Down point


        //Check the walls and restrict movement if needed

        if(leftTile.CompareTag("Wall"))
            mov.goleft = false;
        if(rightTile.CompareTag("Wall"))
            mov.goright = false;
        if(upTile.CompareTag("Wall"))
            mov.goup = false;
        if(downTile.CompareTag("Wall"))
            mov.godown = false;
    }
}
