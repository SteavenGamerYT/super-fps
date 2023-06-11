using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button createButton;
    public Button joinButton;

    void Start()
    {
        // Get the Button components
        createButton = GetComponent<Button>();
        joinButton = GetComponent<Button>();

        // Set the text labels
        createButton.GetComponentInChildren<Text>().text = "Create Game!";
        joinButton.GetComponentInChildren<Text>().text = "Join Game!";
    }
}

public class CreategameAndJoinGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
