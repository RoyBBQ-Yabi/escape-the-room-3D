using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public int HP = 3;
    public int gift =15;
    public int score;


    public AudioClip Sound;
    public AudioClip CoinSound;
    public AudioClip SwitchSound;
    
    //UI
    public GameObject HP_01;
    public GameObject HP_02;
    public GameObject HP_03;
    public Text Gift_num;

    //其他物件
    public GameObject Goal;
    public GameObject special_effects;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gift == 0)
        {
            Goal.SetActive(true);
        }
        if(HP == 0)
        {
            SceneManager.LoadScene("Loss");
        }
    }
    
    //判定
    void OnTriggerEnter(Collider other){

        //Portal
        if(other.tag=="Portal"){
            SceneManager.LoadScene(other.gameObject.GetComponent<Portal>().SceneName);
        }
        if(other.tag=="Portal_Leave"){
            Application.Quit();
        }
        
        //UI
        if(other.tag=="Coin"){
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            gift --;
            Gift_num.text =" : " + gift;
            score += 100;
        }

        if(other.tag=="Switch"){
            AudioSource.PlayClipAtPoint(SwitchSound, transform.position);
        }

        if(other.tag=="Bottle"){
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            if(HP==1)
            {
                HP_02.SetActive(true);
            }
            if(HP==2)
            {
                HP_03.SetActive(true);
            }
            HP++;
            Destroy(other.gameObject);
        }

        if(other.tag =="Enemy" || other.tag =="Trap"){ 

            Instantiate(special_effects,transform.position,transform.rotation);
            AudioSource.PlayClipAtPoint(Sound, transform.position);
            HP--;
            if(HP==2)
            {
                HP_03.SetActive(false);
            }
            if(HP==1)
            {
                HP_02.SetActive(false);
            }
            if(HP==0)
            {
                HP_01.SetActive(false);
            }
        }
        if(other.tag =="test"){}
            
        
        
    }
}
