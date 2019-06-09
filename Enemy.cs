using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 4;
    public int searchRadius;
    public Transform Player;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        transform.SetPositionAndRotation(new Vector3(Random.value * 800 + 200, 0f, Random.value * 800 + 200),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 temp;

       if(Vector3.Distance(Player.position,transform.position) < 100)
        {
            anim.SetBool("PlayerNear", true);
            temp = Player.position;
            temp.y = 0;
            transform.LookAt(temp);
            transform.position += transform.forward * Time.deltaTime;
            if(Vector3.Distance(Player.position, transform.position) < 6)
            {
                anim.SetBool("Attack", true);
            }
            else
            {
                anim.SetBool("Attack", false);
            }
        }
        else
        {
            anim.SetBool("PlayerNear", false);
        }
    }

}
