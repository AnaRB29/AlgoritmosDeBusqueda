using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Expansion : MonoBehaviour
{
    public Tilemap waterTilemap;
    public Tilemap groundTilemap;
    public Vector3Int initialPosition;

    private Queue<Vector3Int> floodQueue;

    void Start()
    {
        floodQueue = new Queue<Vector3Int>();
        ExpandWater(initialPosition);
    }

    void ExpandWater(Vector3Int start)
    {
        floodQueue.Enqueue(start);

        while (floodQueue.Count > 0)
        {
            Vector3Int currentCell = floodQueue.Dequeue();

            // Comprueba los vecinos (arriba, abajo, izquierda, derecha)
            TryToFillCell(currentCell + new Vector3Int(1, 0, 0)); // Derecha
            TryToFillCell(currentCell + new Vector3Int(-1, 0, 0)); // Izquierda
            TryToFillCell(currentCell + new Vector3Int(0, 1, 0)); // Arriba
            TryToFillCell(currentCell + new Vector3Int(0, -1, 0)); // Abajo
        }
    }

    void TryToFillCell(Vector3Int cell)
    {
        if (groundTilemap.GetTile(cell) != null)
        {
            waterTilemap.SetTile(cell, waterTilemap.GetTile(initialPosition)); // Copia el tile de agua inicial
            floodQueue.Enqueue(cell); // Agrega el vecino a la cola para expandirlo
        }
    }
}
