using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if(controller.currentHealth < controller.maxHealth)
            {
                controller.ChangeHealth(2);
                Destroy(gameObject);
            }
        }
    }
}
