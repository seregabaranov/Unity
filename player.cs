using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rgb;
    public float speed = 10;
    //public GameObject portalend;
    //   public GameObject camera;
    //   private Vector3 campos;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
  //      campos = transform.position - camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        float y = 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = 300;
            Debug.Log("Space key was pressed.");
        }
        rgb.AddForce(new Vector3(x * speed, y * speed, z * speed));
   //     camera.transform.position = transform.position - campos;


    }

    void OnTriggerEnter(Collider obj)
    {
      //  Debug.Log("OnTriggerEnter obj");
        if (obj.gameObject.name == "portalstart")
        {
            Debug.Log("OnTriggerEnter portalstart");
            transform.position = 
                obj.gameObject.transform.GetChild(0).transform.position;
        }
    }
}
