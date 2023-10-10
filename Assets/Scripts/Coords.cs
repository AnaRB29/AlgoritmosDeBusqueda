using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Coords : MonoBehaviour
{
    private void GetMouseButtonDown(Transform eventData)
    {
        Debug.Log("Clicked at " + eventData.position.x + ", " + eventData.position.y);
        Tilemap tilemap = gameObject.GetComponent<Tilemap>();
        Vector3Int cellPos = tilemap.WorldToCell(new Vector3(eventData.position.x, eventData.position.y, 0));
        Debug.Log("Clicked at " + cellPos.x + ", " + cellPos.y);
    }
}
