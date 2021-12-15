using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{

    private CharacterController thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;

            } 
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }
        
    }
}
