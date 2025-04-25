using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectiles1;
    [SerializeField] GameObject projectiles2;
    [SerializeField] GameObject projectiles3;
    [SerializeField] GameObject projectiles4;
    [SerializeField] GameObject projectiles5;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectiles1.SetActive(true);
            projectiles2.SetActive(true);
            projectiles3.SetActive(true);
            projectiles4.SetActive(true);
            projectiles5.SetActive(true);
            Destroy(gameObject);
        }
    }
}
