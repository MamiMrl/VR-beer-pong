using UnityEngine;

public class Path  : MonoBehaviour
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

        // Create a Ray object that represents the line
        Ray ray = new Ray(startPosition, endPosition - startPosition);

        // Set up a RaycastHit object to store information about the hit
        RaycastHit hit;

        // Check if the ray intersects with any colliders
        if (Physics.Raycast(ray, out hit))
        {
            // Check if the hit object is a cup
            if (hit.collider.tag == "Cup")
            {
                // Highlight the cup by changing its material or color
                hit.collider.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
