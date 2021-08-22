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

    public void Update()
    {
        // Current point
        currentTile = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y));
        // Left point
        leftTile = Physics2D.OverlapPoint(new Vector2(transform.position.x - 1, transform.position.y));
        // Right point
        rightTile = Physics2D.OverlapPoint(new Vector2(transform.position.x + 1, transform.position.y));
        // Up point
        upTile = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y + 1));
        // Down point
        downTile = Physics2D.OverlapPoint(new Vector2(transform.position.x, transform.position.y - 1));
    }
}
