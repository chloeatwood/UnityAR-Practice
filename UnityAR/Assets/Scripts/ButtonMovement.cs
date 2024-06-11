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
    [SerializeField] private Button InstructionsButton, Settings, pause, unPause, Front, Back,
        Right, Left;

    //Adding a couple other things
    [SerializeField] private bool grounded = false;
    [SerializeField] private GameObject superCheese, glowingSuperCheese;
    private bool MoveLeft, MoveRight, MoveForward, MoveBackward, sprint;



    // Start is called before the first frame update
    void Start()
    {

    }





    // Update is called once per frame
    void Update()
    {
        

        //Calling movement functions when corresponding button is held down
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

    //Dedciding whether or not player is on the ground
    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
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
        if (sprint)
        {
            transform.position = transform.position + Camera.main.transform.forward * RunSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + Camera.main.transform.forward * WalkSpeed * Time.deltaTime;
        }
        Debug.Log("Clicked");
    }
    //Moves player backward when pressing the backwards button
    public void moveBackward()
    {
        if (sprint)
        {
            transform.position = transform.position + Camera.main.transform.forward * -RunSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + Camera.main.transform.forward * -WalkSpeed * Time.deltaTime;
        }

        Debug.Log("Clicked");
    }


    //Moves player left when pressing the left button
    public void moveLeft()
    {
        if (sprint)
        {
            transform.position = transform.position + Camera.main.transform.right * -RunSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + Camera.main.transform.right * -WalkSpeed * Time.deltaTime;
        }
        Debug.Log("Clicked");
    }

    //Moves player right when pressing the right button
    public void moveRight()
    {

        if (sprint)
        {
            transform.position = transform.position + Camera.main.transform.right * RunSpeed * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + Camera.main.transform.right * WalkSpeed * Time.deltaTime;
        }

        Debug.Log("Clicked");
    }


    //Setting Sprint to true or false depending on if button is down or not
    public void sprintDown()
    {
        sprint = true;
    }

    public void sprintUp()
    {
        sprint = false;
    }


    //Pause game function
    public void pauseGame()
    {
        Time.timeScale = 0f;
        InstructionsButton.gameObject.SetActive(true);
        Settings.gameObject.SetActive(true);
        unPause.gameObject.SetActive(true);
        pause.gameObject.SetActive(false);
        Front.gameObject.SetActive(false);
        Back.gameObject.SetActive(false);
        Right.gameObject.SetActive(false);
        Left.gameObject.SetActive(false);

    }


    //Play game function

    public void unPauseGame()
    {
        Time.timeScale = 1f;
        InstructionsButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        unPause.gameObject.SetActive(false);
        pause.gameObject.SetActive(true);
        Front.gameObject.SetActive(true);
        Back.gameObject.SetActive(true);
        Right.gameObject.SetActive(true);
        Left.gameObject.SetActive(true);
    }



    //Jump function. Changed based on cheese colleted
    public void jump()
    {
        if (grounded)
        {
            if (superCheese.activeSelf)
            {
                Player.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            }
            else
            {
                Player.AddForce(Vector3.up * SuperJump, ForceMode.Impulse);
            }
            if (!glowingSuperCheese.activeSelf)
            {
                Player.AddForce(Vector3.up * SuperJump, ForceMode.Impulse);
            }
        }
    }
}

