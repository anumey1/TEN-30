using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoundary : MonoBehaviour {

	
        void OnTriggerExit(Collider other)
        {
        if (other.transform.parent == null)
        {
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(other.transform.parent.gameObject);
        }


    }

}
