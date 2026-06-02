using UnityEngine;

public class Som : MonoBehaviour
{
    private bool grito = false;
    [SerializeField] private AudioClip triggerSound;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the Player
        if (other.CompareTag("Player") & grito == false)
        {
            // Instantiates a temporary 3D audio object at the trigger's position
            AudioSource.PlayClipAtPoint(triggerSound, transform.position);
            grito = true;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
