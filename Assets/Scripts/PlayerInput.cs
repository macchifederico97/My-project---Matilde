using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerInput : MonoBehaviour
{

  
    
    private float horizontalInput;
    private PlayerMovement playerMovement;
     public float movementSpeed=4f;
    private bool jumpPressed; 

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = gameObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButtonDown(0))
        
        {
            playerMovement.Jump();
        }*/
        horizontalInput = Input.GetAxis("Horizontal");
        if(!jumpPressed ){
            jumpPressed = Input.GetButtonDown("Jump");
        }

         if(Input.GetMouseButton(0))  

        {
           Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


           if(mousePos.x > playerMovement.transform.position.x)



             {
                    transform.Translate(movementSpeed * Time.deltaTime, 0, 0); 
                    playerMovement.Move(1);
              }

              else if (mousePos.x < playerMovement.transform.position.x)
               {
                    transform.Translate(-movementSpeed * Time.deltaTime, 0, 0); 
                    playerMovement.Move(-1);
              }

           

        } 




    }

     private void FixedUpdate () {
        if (horizontalInput !=0f  )   {
            playerMovement.Move(horizontalInput);
        }
        if (jumpPressed) {
            playerMovement.Jump();
            jumpPressed=false;
        }

 }
                  
}
