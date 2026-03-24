using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Swith : MonoBehaviour
{
    public GameObject traps_01;
    public GameObject traps_02;
    public GameObject traps_03;
    public GameObject traps_04;

    void OnTriggerEnter(Collider other)
    {
        //陷阱開關
        if(other.tag == "Player")
        {
            traps_01.SetActive(true);
            traps_02.SetActive(true);
            traps_03.SetActive(true);
            traps_04.SetActive(true);
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
