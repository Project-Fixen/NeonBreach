using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRPS : MonoBehaviour
{
    public int move; 
    public RPS logic;

    void OnMouseOver () {
        if (Input.GetMouseButtonDown(0)) {
            logic.OnClick(move);
        }
    }
}
