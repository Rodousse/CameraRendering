using UnityEngine;
using System.Collections;

public class SplitManager : MonoBehaviour {

    private GameObject player1;
    private GameObject player2;
    private bool toggle;

	// Use this for initialization
	void Start () {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        toggle = true;
        player2.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        player1.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
    }

    // Update is called once per frame
    void Update () {
	 if(Input.GetMouseButtonDown(0))
        {
            toggle = !toggle;
            Debug.Log("lala");
            if(toggle)
            {
                player2.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
                player1.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;

            }
            else
            {
                player2.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
                player1.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
            }


        }
	}
}
