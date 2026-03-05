using UnityEngine;

public class Uranus : MonoBehaviour
{
    //Public Methods
    public Transform sun;

    //Private Methods
    private float rotationSpeed = 0.0205f;
    private float distanceSun = 1505.4915f;
    private float scale = 5.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(distanceSun, 0, 0);
        transform.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.position, Vector3.up, rotationSpeed * Time.deltaTime);
        Debug.DrawLine(transform.position, sun.transform.position, Color.red);
    }
}
