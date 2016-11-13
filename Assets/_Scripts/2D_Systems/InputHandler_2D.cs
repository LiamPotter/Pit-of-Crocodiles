using UnityEngine;
using System.Collections;
using Rewired;
public class InputHandler_2D : MonoBehaviour {

    public static Player player;

    public float horizontalValue;

	void Awake ()
    {
        player = ReInput.players.GetPlayer(0);
	}
    public void GetInput()
    {
        horizontalValue = player.GetAxis("Horizontal");
    }

}
