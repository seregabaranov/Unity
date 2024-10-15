using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0, y = 0;
        if (Input.GetKey(KeyCode.D)) x = speed;
        if (Input.GetKey(KeyCode.A)) x = -speed;
        if (Input.GetKey(KeyCode.W)) y = speed;
        if (Input.GetKey(KeyCode.S)) y = -speed;
        
        transform.position = new Vector2(transform.position.x + x,
                                         transform.position.y + y);
        
    }
}
