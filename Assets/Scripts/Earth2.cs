using UnityEngine;

public class Earth2 : MonoBehaviour
{
    //Public Methods
    public Transform sun;
    public Transform cam;

    //Private Methods
    private float rotationSpeed = 0.986f;
    private float distanceSun = 3699.915f;
    private float scale = 12.76f;

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

        cam.transform.position = new Vector3(transform.position.x, 200,transform.position.z);
        cam.LookAt(transform.position);
    }
}
