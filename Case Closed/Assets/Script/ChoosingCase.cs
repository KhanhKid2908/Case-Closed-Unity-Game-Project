using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingCase : MonoBehaviour
{
    public GameObject cutSceneCam, canvas;

    void SwitchToPlayerCam()
    {
        cutSceneCam.SetActive(false);
        canvas.SetActive(true);
    }

    // Start is called before the first frame update
    void Start() 
    {
        cutSceneCam.SetActive(true);
        canvas.SetActive(false);
        Invoke("SwitchToPlayerCam", 2f);         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
