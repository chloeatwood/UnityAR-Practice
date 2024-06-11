using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;




public class UIManager : MonoBehaviour
{
    [SerializeField] Button startTimerMode, startExploreMode, Exit, InstructionsButton, 
        BackButtonMainMenu, NextPage, BackPage, Settings, Jump, Sprint, Left, Right, 
        Front, Back, NextPage2, BackPage2;
    [SerializeField] TMP_Text timerText, timerCount, timeElapsed, timeCount, 
        Instructions, Hints, ARInstructions;
    [SerializeField] GameObject Background, SettingsCannvas, Plane;
    [SerializeField] AudioMixer audioMixer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Function to reset the game round
    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    //Function to quit out of the application
    public void exitGame()
    {
        Application.Quit();

    }
    
    //Makes a plane dissappear
    public void plane()
    {
        Plane.gameObject.SetActive(false);
    }

    //Starts the game in timer mode
    public void timerMode()
    {
        timerCount.gameObject.SetActive(true);
        timerText.gameObject.SetActive(true);
        startTimerMode.gameObject.SetActive(false);
        startExploreMode.gameObject.SetActive(false);
        Exit.gameObject.SetActive(true);
        InstructionsButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
    }


    //Starts the game in free play mode
    public void freeMode()
    {
        timeElapsed.gameObject.SetActive(true);
        timeCount.gameObject.SetActive(true);
        startTimerMode.gameObject.SetActive(false);
        startExploreMode.gameObject.SetActive(false);
        Exit.gameObject.SetActive(true);
        InstructionsButton.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
    }


    //Shows the first page of instructions
    public void showingInstructions()
    {
        InstructionsButton.gameObject.SetActive(false);
        BackButtonMainMenu.gameObject.SetActive(true);
        Instructions.gameObject.SetActive(true);
        Background.SetActive(true );
        NextPage.gameObject.SetActive(true);
        Settings.gameObject.SetActive(false);
        BackPage.gameObject.SetActive(false);
        BackPage2.gameObject.SetActive(false);


    }


    //Leaves instructions and goes back to main menu
    public void backToMain()
    {
        InstructionsButton.gameObject.SetActive(true);
        BackButtonMainMenu.gameObject.SetActive(false);
        Instructions.gameObject.SetActive(false);
        Background.SetActive(false);
        NextPage.gameObject.SetActive(false);
        Hints.gameObject.SetActive(false);
        BackPage.gameObject.SetActive(false);
        SettingsCannvas.SetActive(false);
        Settings.gameObject.SetActive(true);
        ARInstructions.gameObject.SetActive(false);
        NextPage2.gameObject.SetActive(false);
        BackPage2.gameObject.SetActive(false);
    }


    //Takes you to the second page of instructions
    public void secondPageInfo()
    {
        BackButtonMainMenu.gameObject.SetActive(true);
        Background.SetActive(true);
        NextPage.gameObject.SetActive(false);
        BackPage.gameObject.SetActive(true);
        Hints.gameObject.SetActive(true);
        Instructions.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        NextPage2.gameObject.SetActive(true);
        ARInstructions.gameObject.SetActive (false);
        BackPage2.gameObject.SetActive(false);

    }


    //Takes you back a page in the instructions tab
    public void backAPage()
    {
        BackButtonMainMenu.gameObject.SetActive(true);
        Background.SetActive(true);
        NextPage.gameObject.SetActive(true);
        BackPage.gameObject.SetActive(false);
        Hints.gameObject.SetActive(false);
        Instructions.gameObject.SetActive(true);
        Settings.gameObject.SetActive(false);

    }

    //Opens the game settings
    public void openSettings()
    {
        InstructionsButton.gameObject.SetActive(false);
        BackButtonMainMenu.gameObject.SetActive(true);
        Settings.gameObject.SetActive(false);
        Background.SetActive(true);
        SettingsCannvas.SetActive(true);
    }


    //Sets the volume of the music
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }


    //Takes you to the 3rd page of instructions
    public void specialARInstructions()
    {
        BackButtonMainMenu.gameObject.SetActive(true);
        Background.SetActive(true);
        NextPage.gameObject.SetActive(false);
        BackPage.gameObject.SetActive(false);
        Hints.gameObject.SetActive(false);
        Instructions.gameObject.SetActive(false);
        Settings.gameObject.SetActive(false);
        NextPage2.gameObject.SetActive(false);
        BackPage2.gameObject.SetActive(true);
        ARInstructions.gameObject.SetActive(true);

    }

}
