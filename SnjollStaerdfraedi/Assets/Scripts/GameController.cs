using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //Adds a reference to GameController
    [SerializeField]
    private InputField input;

    //This function runs as soon as game begins.
    //Here we initialize values.
    void Awake()
    {
        //input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void GetInput(string guess)
    {
        Debug.Log("You entered " + guess);

        //Resets input.
        input.text = "";
    }

}
