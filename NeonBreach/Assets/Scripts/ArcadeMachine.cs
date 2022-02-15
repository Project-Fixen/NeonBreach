using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMachine : MonoBehaviour
{
    public bool usesMouse;
    
    public GameObject Game;
    public GameObject Camera;
    public GameObject Manager;

    public void onInteract() {
        if (usesMouse) MouseUnlock();
        Camera.SetActive(true);
        if (Manager != null) Manager.SetActive(true);
    }
    
    public void onExit() {
        if (usesMouse) MouseLock();
        Camera.SetActive(false);
        if (Manager != null) Manager.SetActive(false);
    }

    void MouseUnlock() {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    void MouseLock() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
