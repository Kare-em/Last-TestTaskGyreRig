using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float period;
    [SerializeField] private float velocity;
    [SerializeField] private float distance;
    [SerializeField] private GameObject cubePrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            GameObject tempCube = Instantiate(cubePrefab);
            Cube cube = tempCube.GetComponent<Cube>();
            cube.Velocity = velocity;
            cube.Distance = distance;
            yield return new WaitForSeconds(period);
        }
    }

}
