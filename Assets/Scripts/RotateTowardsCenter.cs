using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsCenter : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {
            spriteRenderer.flipX = true; // Lật hero về bên trái
        }
        else
        {
            Debug.LogError("SpriteRenderer chưa được gán cho " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
