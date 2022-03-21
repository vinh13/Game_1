using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawner;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    private void Start()
    {
        StartCoroutine(SpawnerMonters());
    }


    IEnumerator SpawnerMonters()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawner = Instantiate(monsterReference[randomIndex]);
            if (randomSide == 0)
            {
                spawner.transform.position = leftPos.position;
                spawner.GetComponent<Monster>().speed = Random.Range(4, 10);
            }
            else
            {
                spawner.transform.position = rightPos.position;
                spawner.GetComponent<Monster>().speed = -Random.Range(4, 10);
                spawner.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }

    }

}
