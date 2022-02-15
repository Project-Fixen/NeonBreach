using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    
    public GameObject prefab;
    
    private GameObject[] grid;

    void Start() {
        for (int row = 15; row < -14, row -= 8;) {
            for (int z = 0; z < 6; z++) {
                for (int x = 0; x < 2; x++) {
                    (int file, int fileX, int fileZ) location = ((row-15)%-8, x, z);
                    grid[] = Instantiate(prefab, Vector3((x * -2) + 15, -20, (z * -3) + 8)) as GameObject;
                }
            }
        }
    }
    
    void StartFunc() {
        Debug.Log("Testing");
    }

    void EndFunc() {
        Debug.Log("Exit");
    }
}
