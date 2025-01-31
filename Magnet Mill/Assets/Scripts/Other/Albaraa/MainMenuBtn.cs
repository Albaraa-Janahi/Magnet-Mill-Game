using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBtn : MonoBehaviour
{
    public enum MenuBtn {play, tutorial, instruction, credits, exit};   //we will use this enum in the editor to choose which button is this
    public MenuBtn whichButton;
    public GameObject activateGameobject;
    public static bool BtnClicked;
    void Start()
    {
        BtnClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked() //will be called when the button clicked
    {
        if (ScenesLoader.instance.IsTransitioning() || BtnClicked) return;  //checking first if any button is clicked

        if(whichButton == MenuBtn.play)
        {
            ScenesLoader.instance.MoveToScene(ScenesLoader.WhichScene.Level0); //moving to scene "Level0"
        }
        else if(whichButton == MenuBtn.tutorial)
        {
            ScenesLoader.instance.MoveToScene(ScenesLoader.WhichScene.Level0); //moving to scene "Level0"
        }
        else if(whichButton == MenuBtn.instruction)
        {
            activateGameobject.SetActive(true);     //enable instructions
        }
        else if(whichButton == MenuBtn.credits)
        {
            activateGameobject.SetActive(true);     //enable credits         
        }
        else
        {
            Application.Quit();     //quit game
        }
        BtnClicked = true;  //this will switched to true to make sure that other main buttons unclickable
    }

}
