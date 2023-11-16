using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButtonScript : MonoBehaviour
{
    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
            print("NO");
        if(Input.GetMouseButtonDown(0))
        {
            print("Jump");
            playerMovement.Jump();
        }
    }
}
