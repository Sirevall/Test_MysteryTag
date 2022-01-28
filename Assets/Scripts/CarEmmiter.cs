using System.Collections;
using UnityEngine;

public class CarEmmiter : MonoBehaviour
{
    public GameObject CarPrefab;
    public GameObject ScrewPrefab;

    private Car _car;
    void Start()
    {
        CreateCar();
    }
    public void CreateCar()
    {
        _car = Instantiate<GameObject>(CarPrefab, transform.position, transform.rotation).GetComponent<Car>();
        _car.IsDestroy.AddListener(CreateNewCar);
    }
    public void CreateNewCar()
    {
        StartCoroutine(RespawnCar());
    }
    IEnumerator RespawnCar()
    {
        yield return new WaitForSeconds(4);
        CreateCar();
        yield break;
    }
}
