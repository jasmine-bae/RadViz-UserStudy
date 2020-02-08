using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Camera2DOn;
    public Camera Camera2D;

    public bool Camera3DOn;
    public Camera Camera3D;

    public bool powerLevelsOn;
    public Canvas powerLevels;

    void Start()
     {
        Camera2D.enabled = Camera2DOn;
        Camera3D.enabled = Camera3DOn;
        powerLevels.gameObject.SetActive(powerLevelsOn);
     }
}
