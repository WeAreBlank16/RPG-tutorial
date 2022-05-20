using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  [RequireComponent(typeof(BoxCollider2D))]
public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        private BoxCollider2D boxCollider;

        private Vector3 moveDelta;

        private void Start()
    {
        boxCollider = GetComponent<boxCollider>();
    }
    private void FixedUpdate()
    {
        // Reset moveDelta, for stopping character movement
        moveDelta = Vector3.zero;

        float x = Input.GetAxisRaw("Horizontal");
    }
}
