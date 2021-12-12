using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
    public GameObject bookView;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            bookView.SetActive(true);
        }
        else
        {
            bookView.SetActive(false);
        }
    }
}
