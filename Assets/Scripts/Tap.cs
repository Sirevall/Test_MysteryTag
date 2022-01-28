using UnityEngine;

public class Tap : MonoBehaviour
{
    public GameObject TapEffect;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(TapEffect, transform.position, transform.rotation);
        }
    }
}
