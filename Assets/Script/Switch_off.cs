using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Switch_off : MonoBehaviour
{
    public GameObject traps_01;
    public GameObject traps_02;
    public GameObject traps_03;
    public GameObject traps_04;
    public GameObject traps_05;
    public GameObject traps_06;
    public GameObject traps_07;
    public AudioClip Sound;
    void OnTriggerEnter(Collider other)
    {
        //陷阱開關
        if(other.tag == "Player")
        {
            traps_01.SetActive(false);
            traps_02.SetActive(false);
            traps_03.SetActive(false);
            traps_04.SetActive(false);
            traps_05.SetActive(false);
            traps_06.SetActive(false);
            traps_07.SetActive(false);
            AudioSource.PlayClipAtPoint(Sound, transform.position);
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
