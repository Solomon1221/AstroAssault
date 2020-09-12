using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LearnProgrammingAcademy.AstroAssault
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class FallingBehavior : MonoBehaviour
    {
        // == fields ==
        [SerializeField]
        private float speed = 2f;

        private Rigidbody2D body;

        // == messages ==
        private void Start()
        {
            body = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            body.velocity = Vector2.down * speed;
        }
    }
}
