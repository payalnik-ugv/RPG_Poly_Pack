using UnityEngine;
using System.Collections;

public class CouroutineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCourutine());
    }

    // Требует вернуть задержку между тем времени, сколько должно пройти перед началом выполнения кода в скрипте
    public IEnumerator SpawnCourutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
