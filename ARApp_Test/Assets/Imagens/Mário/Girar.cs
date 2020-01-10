using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GirarCabeca());
    }

    IEnumerator GirarCabeca()
    {
        transform.Rotate(0, 0, 90);

        yield return new WaitForSeconds(0.5f);
    }
}
