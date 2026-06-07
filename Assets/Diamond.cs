using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private GameObject diamondVisual;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start Diamond script");
    }

    // Update is called once per frame
    void Update()
    {
        diamondVisual.transform.Rotate(0, 3, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
