using UnityEngine;

public class TrafficScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,0.06f);
    
    if ( transform.position.z > 438.7f)
    {
        Vector3 v = transform.position;
        v.z = -479.2f;
        transform.position = v;
    }
    }
}
