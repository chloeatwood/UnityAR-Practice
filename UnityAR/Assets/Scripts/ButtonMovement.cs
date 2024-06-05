using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;


//Seems to revert back to (0,0,0) after each movement? Works fine in editor but not on app
public class ButtonMovement : MonoBehaviour
{
    //Initializing Player
    [SerializeField] private Rigidbody Player;

    //Initializing Speeds, and Jumps
    [SerializeField] private float WalkSpeed, RunSpeed, JumpForce, SuperJump;

    //Adding necessary Buttons
    

    //Adding a couple other things
    [SerializeField] private bool grounded = false;
    [SerializeField] private GameObject superCheese, glowingSuperCheese;
    [SerializeField] private bool GameIsPaused = false;

    private bool MoveLeft, MoveRight, MoveForward, MoveBackward;


    private float xRot;

    private float Sensitivity = 3;

    Vector2 PlayerMouse;



    // Start is called before the first frame update
    void Start()
    {

    }

    //Sets player direction movement to true or false depending on if button is pressed
    public void DownMoveForward()
    {
        MoveForward = true;
    }

    public void UpMoveForward()
    {
        MoveForward = false;
    }

    public void DownMoveBackward()
    {
        MoveBackward = true;
    }

    public void UpMoveBackward()
    {
        MoveBackward = false;
    }

    public void DownMoveLeft()
    {
        MoveLeft = true;
    }

    public void UpMoveLeft()
    {
        MoveLeft = false;
    }

    public void DownMoveRight()
    {
        MoveRight = true;
    }

    public void UpMoveRight()
    {
        MoveRight = false;
    }

    //Moves player forward when pressing the forward button
    public void moveForward()
    {
        Player.velocity += Vector3.forward * WalkSpeed * Time.deltaTime;
        Debug.Log("Clicked");
    }
    //Moves player backward when pressing the backwards button
    public void moveBackward()
    {
        transform.Translate(0f, 0f, -1f * WalkSpeed * Time.deltaTime);
        Debug.Log("Clicked");
    }


    //Moves player left when pressing the left button
    public void moveLeft()
    {
        transform.Translate(-1f * WalkSpeed * Time.deltaTime, 0f, 0f);
        Debug.Log("Clicked");
    }

    //Moves player right when pressing the right button
    public void moveRight()
    {
        transform.Translate(1f * WalkSpeed * Time.deltaTime, 0f, 0f);
        Debug.Log("Clicked");
    }

   /* private void MovePlayerDirection()
    {
        if (Time.timeScale == 1)
        {
            xRot -= PlayerMouse.y * Sensitivity;

            transform.Rotate(0f, PlayerMouse.x * Sensitivity, 0f);
            transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        }
    }*/



    // Update is called once per frame
    void Update()
    {
        /*PlayerMouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        MovePlayerDirection();*/

        if (MoveForward) 
        {
            moveForward();
        }
        if (MoveBackward)
        {
            moveBackward();
        }
        if (MoveLeft)
        {
            moveLeft();
        }
        if (MoveRight)
        {
            moveRight();
        }
    }

    
}

