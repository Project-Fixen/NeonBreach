using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject prefab;
    
    private GameObject[] grid;
    
    void interact() {
        for (int row = 15; row < -14, row -= 7;) {
            for (int z = 0; z < 6; z++) {
                for (int x = 0; x < 2; x++) {
                    Instantiate(prefab, Vector3((x * -2) + 15, -20, (z * -3) + 8))
                }
            }
        }
    }

}
