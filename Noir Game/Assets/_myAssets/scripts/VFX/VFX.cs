using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX : MonoBehaviour
{
    public ParticleSystem particleSystems;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(particleSystems);
        }
    }

}
