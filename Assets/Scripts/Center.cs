using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Center : MonoBehaviour
{
    [SerializeField] private Tilemap map;
    private Camera cam;
    [SerializeField] private Transform playerTransform;

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var worldPos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int tilemapPos = map.WorldToCell(worldPos);
            playerTransform.position = map.CellToWorld(tilemapPos);
            Debug.Log(tilemapPos);
        }
    }
}
