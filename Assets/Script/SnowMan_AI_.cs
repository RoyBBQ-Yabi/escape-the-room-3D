using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SnowMan_AI_ : MonoBehaviour
{
    public Transform Target;   //目標
    NavMeshAgent NMA;

    void Start()
    {
        NMA = GetComponent<NavMeshAgent>();   //獲取NavMeshAgent component
        NMA.destination = Target.position;   //設定目標位置(Target的座標)

    }

    void Update()
    {
        NMA.destination = Target.position;

    }
}
