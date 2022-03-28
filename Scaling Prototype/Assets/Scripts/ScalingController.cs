using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingController : MonoBehaviour
{
    public float scaleSpeed;
    public float minScale;
    public float maxScale;

    private float scaleMultiplier = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeScale();
    }

    void ChangeScale()
    {
        transform.localScale += Input.GetAxis("Scale") * scaleSpeed * scaleMultiplier * Time.deltaTime * Vector3.one;
        transform.localScale = Mathf.Clamp(transform.localScale.x, minScale, maxScale) * Vector3.one;
    }
}
