using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Move : MonoBehaviour
{

    public Transform[] points;
    private int destpoint = 0;
    private NavMeshAgent agent;
    void Start () {
        agent = GetComponent<NavMeshAgent>();

        // 取消自動煞車將允許點之間的
        // 連續移動（即，代理在接近目標點時不會浪費）。
        agent.autoBraking = false;

        GotoNextPoint();
    }

    void GotoNextPoint() {
                // 如果未設定任何點，則返回
                if (points.Length == 0)
                    return;

                //將代理程式設定為前往目前選定的目標。
                agent.destination = points[destpoint].position;

                //選擇資料庫中的下一個點作為目標，如果需要，循環到開始。
                destpoint = (destpoint + 1) % points.Length;
            }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f){
            GotoNextPoint();
        }
    }
}
