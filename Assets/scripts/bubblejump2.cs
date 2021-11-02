using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class bubblejump2 : MonoBehaviour
{
    // Movement speed
    public float speed = 2;

    // Flap force
    public float force = 300;

    // Use this for initialization
    void Start()
    {
        // Fly towards the left
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

   
    // Called when a collision occurs (ie. Bird hits the ground, or a object)
    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

