using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loss_Back : MonoBehaviour
{
    public GameObject Back;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Back"){
            SceneManager.LoadScene(other.gameObject.GetComponent<Portal>().SceneName);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
