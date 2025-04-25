using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class SpinningObstacle : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 3f;

    [SerializeField] float zAngle = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
