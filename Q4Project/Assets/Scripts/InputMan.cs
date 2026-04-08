using UnityEngine;
using UnityEngine.InputSystem;

// Input Manager. Ryft if you touch this I swear to god.

// HOW TO USE INPUT MANAGER!
// Any time you want to check an input, just check "InputMan.button#".
// If you only want to check the instance the key was hit, use "InputMan.tap#"
// There is no buttonESC, only tapESC.

public class InputMan : MonoBehaviour
{
    static public bool buttonW = false;
    static public bool tapW = false;
    static public bool buttonA = false;
    static public bool tapA = false;
    static public bool buttonS = false;
    static public bool tapS = false;
    static public bool buttonD = false;
    static public bool tapD = false;
    static public bool tapESC = false;

    // Check for inputs
   void Update()
    {
        if(Keyboard.current != null) // Only run code IF THERE IS A KEYBOARD CONNECTED OR EVERYONE WILL DIE.
        {
            // Check if the key is tapped (or held)
            buttonW = (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed || Keyboard.current.spaceKey.isPressed);
            tapW = (Keyboard.current.wKey.wasPressedThisFrame || Keyboard.current.upArrowKey.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame);
            buttonA = (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed);
            tapA = (Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.leftArrowKey.wasPressedThisFrame);
            buttonS = (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed);
            tapS = (Keyboard.current.sKey.wasPressedThisFrame || Keyboard.current.downArrowKey.wasPressedThisFrame);
            buttonD = (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed);
            tapD = (Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.rightArrowKey.wasPressedThisFrame);
            tapESC = (Keyboard.current.escapeKey.wasPressedThisFrame);
        }
    }
}