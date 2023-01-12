using UnityEngine;

public class LineTracer : MonoBehaviour
{
    // The LineRenderer component that will be used to draw the line
    public LineRenderer lineRenderer;

    // The start and end positions of the line
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Start()
    {
        // Set the start and end positions of the line to the current position of the object
        startPosition = transform.position;
        endPosition = transform.position;
    }

    void Update()
    {
        // Update the start and end positions of the line based on input from the VR controller
        startPosition = transform.position;
        endPosition.x = Input.GetAxis("ControllerX");
        endPosition.y = Input.GetAxis("ControllerY");
        endPosition.z = Input.GetAxis("ControllerZ");

        // Set the positions of the LineRenderer
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, endPosition);
    }
}
