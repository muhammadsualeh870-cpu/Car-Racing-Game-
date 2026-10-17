using UnityEngine;

public class CarScript : MonoBehaviour
{
   float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      speed = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(0,0, 0.9f*speed);
    if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >-6)
     {
        transform.Rotate(0, -0.2f, 0);
     }
     if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 7.5)
     {
        transform.Rotate(0, 0.2f, 0);
     }
     if (transform.position.z > 438.7f)
     {
   Vector3 v = transform.position;
     v.z = -479.2f;
     transform.position = v;
     }
     if (Input.GetKey(KeyCode.UpArrow) && speed < 1)
     {
        speed = speed+0.01f;
     }
     if (Input.GetKey(KeyCode.DownArrow) && speed > 0)
     {
        speed = speed-0.01f;
     }
     
    }
}
