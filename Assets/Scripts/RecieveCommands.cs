using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveCommands : MonoBehaviour {

	// Use this for initialization
    public Transform target;
    public float speed;
	public void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
        //     float step = speed * Time.deltaTime;
        // transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }
}
