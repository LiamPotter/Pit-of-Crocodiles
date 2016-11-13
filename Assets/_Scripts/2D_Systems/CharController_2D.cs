using UnityEngine;
using System.Collections;

public class CharController_2D : MonoBehaviour {

    public static CharacterController CharacterController;

    public static CharController_2D Instance;

    public static InputHandler_2D InputHandler;

	void Awake ()
    {
        try
        {
            CharacterController = GetComponent<CharacterController>();
            InputHandler = GetComponent<InputHandler_2D>();
        }
        catch (System.Exception)
        {
            Debug.LogError("The Player needs to have a CharacterController and InputHandler_2D component!");
            throw;
        }
        Instance = this;
	}
	
	void Update ()
    {
        if (Camera.main == null)
            return;
        GetLocomotionInput();
	}
    void GetLocomotionInput()
    {
        InputHandler.GetInput();
        Debug.Log(InputHandler.horizontalValue);
    }
}
