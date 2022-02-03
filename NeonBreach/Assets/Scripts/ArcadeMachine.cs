using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMachine : MonoBehaviour
{
    public GameObject Game;
    public GameObject Camera;


    public void onInteract() {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        
        Camera.SetActive(true);
        Debug.Log("Hit");
    }
    
    public void onExit() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        Camera.SetActive(false);
    }
}
