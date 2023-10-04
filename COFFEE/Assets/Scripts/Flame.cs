using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    [SerializeField] GameObject[] FLAMEPrefab;

    [SerializeField] float secondSpawn = 0.5f;

    [SerializeField] float minTras;

    [SerializeField] float maxTrans;

    void Start()
    {
        StartCoroutine(FlameSpawn());
    }

    IEnumerator FlameSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(FLAMEPrefab[Random.Range(0, FLAMEPrefab.Length)],
                position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
    
}
