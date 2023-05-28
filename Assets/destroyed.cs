using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class destroyed : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pop;
    void OnDestroy()
    {
        Instantiate(pop, transform.position, Quaternion.identity);
    }
}
