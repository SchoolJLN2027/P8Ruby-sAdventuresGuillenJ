using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RubyController : MonoBehaviour
{
    //health data
    public int maxHealth = 5;
    public int health { get { return currentHealth; }}
    int currentHealth;

    Rigidbody2D rigidbody2d;
    //store input data
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        

    }
    public void FixedUpdate()
    {
        //uses the rigidbody position for updates
        Vector2 position = rigidbody2d.position;
        position.y = position.y + (3.0f * vertical) * Time.deltaTime;
        position.x = position.x + (3.0f * horizontal) * Time.deltaTime;
        //will update the rigidbody position
        rigidbody2d.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
