using UnityEngine;

public class Moon : MonoBehaviour
{
    //Public Methods
    public Transform earth;

    //Private Methods
    private float rotationSpeed = 360f;
    private float distanceEarth = 3713.983f;
    private float scale = 3.474f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(distanceEarth, 0, 0);
        transform.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(earth.position, Vector3.up, rotationSpeed * Time.deltaTime);
        Debug.DrawLine(transform.position, earth.transform.position, Color.green);
    }
}
