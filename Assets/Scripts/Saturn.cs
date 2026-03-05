using UnityEngine;

public class Saturn : MonoBehaviour
{
    //Public Methods
    public Transform sun;

    //Private Methods
    private float rotationSpeed = 0.0584f;
    private float distanceSun = 783.4915f;
    private float scale =12f;

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
    }
}
