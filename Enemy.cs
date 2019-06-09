using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 4;
    public int searchRadius;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 temp;
       if(Vector3.Distance(Player.position,transform.position) < 10)
        {
            temp = Player.position;
            temp.y = 0;
            transform.LookAt(temp);
            transform.position += transform.forward * Time.deltaTime;
        }
    }

}
