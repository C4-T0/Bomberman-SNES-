using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DamagingObject"))
        {
            DeathSequence();
        }
    }

    private void DeathSequence()
    {
        enabled = false;
        animator.SetBool("isDeath", true);

        Invoke(nameof(Death), 1.5f);
    }

    private void Death()
    {
        gameObject.SetActive(false);
    }
}