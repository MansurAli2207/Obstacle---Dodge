using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDelay = 2f;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToDelay)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
           
        }

    }
}
