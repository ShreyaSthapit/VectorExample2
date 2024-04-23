using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SimplePickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    // Called when the game object the script is attached to collides with another game object.
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("VirtualCharacter"))
        {
            Debug.Log("Pineapple Hit!!");
            Destroy(gameObject);
        }
    }
}