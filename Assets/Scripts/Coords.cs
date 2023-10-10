using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Coords : MonoBehaviour
{
    public Tilemap tilemap; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = tilemap.WorldToCell(mouseWorldPos);
            int x = cellPosition.x;
            int y = cellPosition.y;
            int z = cellPosition.z;

            Debug.Log("Coordenadas del tile: (" + x + ", " + y + ", " + z + ")");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = tilemap.WorldToCell(mouseWorldPos);
            int x = cellPosition.x;
            int y = cellPosition.y;
            int z = cellPosition.z;

            Debug.Log("Coordenadas del objetivo: (" + x + ", " + y + ", " + z + ")");
        }
    }

}
