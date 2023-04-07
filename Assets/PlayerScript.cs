using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public string levelSelect;
    public Vector2 speed = new Vector2(50, 50);
    private Vector2 movement;
    public Rigidbody2D rd2;
    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(inputX, inputY);
    }

    private void FixedUpdate()
    {
        rd2.velocity = movement;
    }
}