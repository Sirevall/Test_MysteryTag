using UnityEngine;
using UnityEngine.Events;

public class Car : MonoBehaviour
{
    public GameObject ResourcePrefab;
    public GameObject ExplosionPrefab;
    public GameObject TapEffect;
    public UnityEvent IsDestroy;

    private Animation _anim;

    private void Start()
    {
        _anim = gameObject.GetComponent<Animation>();
    }
    public void DestroyCar()
    {
        IsDestroy.Invoke();
        IsDestroy.RemoveAllListeners();
        Destroy(gameObject);
    }
    public void CreateResources()
    {
        Instantiate(ResourcePrefab, transform.position, transform.rotation);
    }
    public void Explode()
    {
        Instantiate(ExplosionPrefab, transform.position, transform.rotation);
    }
    private void OnMouseDown()
    {
        _anim.Play();
    }
}
