using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RedSquare : MonoBehaviour
{
    
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IEnumerator());

    }
    IEnumerator IEnumerator()
    {
        transform.position = new Vector2(1f, 1f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(1.5f, 3f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(0.4f, -3f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(-1.5f, 3f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(1f, 1f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(1.5f, 3f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(0.4f, -3f);
        yield return new WaitForSeconds(2);
        transform.position = new Vector2(-1.5f, 3f);
        yield return new WaitForSeconds(2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
