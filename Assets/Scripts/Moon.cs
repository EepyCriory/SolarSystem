using UnityEngine;

public class Moon : MonoBehaviour
{
    //Public Methods
    public Transform earth;

    //Private Methods
    private float rotationSpeed = 360f;
    private float distanceEarth = 14.068f;
    private float scale = 0.2722571f;

    void Start()
    {
        transform.position = earth.position + new Vector3(distanceEarth, 0, 0);
        transform.localScale = new Vector3(scale, scale, scale);
    }

    void Update()
    {
        transform.RotateAround(earth.position, Vector3.up, rotationSpeed * Time.deltaTime);
        Debug.DrawLine(transform.position, earth.transform.position, Color.green);
    }
}