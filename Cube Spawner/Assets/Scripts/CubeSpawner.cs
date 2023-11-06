using UnityEngine;
using Random = UnityEngine.Random;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _cubePrefab;

    private void Update()
    { 
        if (Input.GetKey(KeyCode.Space))
        {
            var newCube = Instantiate(_cubePrefab);
            newCube.transform.position = new Vector3(Random.Range(-10, 10), 10, -4);
        }
    }
    
}
