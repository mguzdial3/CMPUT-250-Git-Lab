using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{

    public float timeDisappear = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitTillDelete(timeDisappear));
    }

    IEnumerator waitTillDelete(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
