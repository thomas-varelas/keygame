using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractKEy : MonoBehaviour
{
    public bool isInRange;
    public KeyCode InteractKey;
    public UnityEvent interactAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(InteractKey))
            {
                interactAction.Invoke();
            }
        }   
    }

    /*
    private void onTriggerEnter(Collider collision)
    {
        if(collision.GameObject.CompareTag("Main Camera"))
        {
            isInRange = true;
        }
    }

        private void onTriggerExit(Collider collision)
    {
        if(collision.GameObject.CompareTag("Main Camera"))
        {
            isInRange = false;
        }
    }
    */
}
