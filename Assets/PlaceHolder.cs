using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolder : MonoBehaviour
{
    public GameObject Placer; //üretir kameraya bırakır
    public Transform CameraPlace;
    private void Start()
    {
       Placer = new GameObject();
       //Instantiate(Placer, transform.position, Quaternion.identity);

    }
    public void Hold_The_Place(Transform pos)
    {
        Instantiate(Placer,pos);
    }

    public Transform Access_The_Place()
    {
       Transform Old = GameObject.FindWithTag("Placer").GetComponent<GameObject>().transform;
        return Old;
    }

    public void Leave_The_Place()
    {
        Destroy(Placer);
    }
}
