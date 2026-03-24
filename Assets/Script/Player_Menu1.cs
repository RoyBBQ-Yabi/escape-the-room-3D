using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Menu1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject StartPortal;
    public GameObject LeavePortal;
    public GameObject Pause_Menu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            Pause_Menu.SetActive(false);
            Time.timeScale = 1;
        }*/
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Portal"){
            SceneManager.LoadScene(other.gameObject.GetComponent<Portal>().SceneName);
        }
        if(other.tag=="Menu_Portal"){
            Application.Quit();
        }
    }
}
