using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playParticles : MonoBehaviour
{
    public GameObject Collectable;
    public ParticleSystem particle;

    bool particleEmitted = false;
    // Update is called once per frame
    void Update()
    {
        if (Collectable == null)
        {
            Debug.Log("inside collectable");
            if (particleEmitted == false)
            {
                Debug.Log("inside collectable 2");
                particle.Emit(10);
                particleEmitted = true;
            }
        }
    }
}
