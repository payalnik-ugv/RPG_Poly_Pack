using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private GameObject diamondVisual;

    // Update is called once per frame
    void Update()
    {
        diamondVisual.transform.Rotate(0, (3 + Time.deltaTime), 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Inventory inventory = other.GetComponent<Inventory>();
            inventory.AddDiamond();
        }
    }
}
