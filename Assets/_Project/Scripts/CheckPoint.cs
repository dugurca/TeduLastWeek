using System.Collections;
using UnityEngine;

namespace Assets._Project.Scripts
{
    public class CheckPoint : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            var rootTransform = other.transform.root;
            if (rootTransform.tag.Equals("Player"))
            {
                Debug.LogWarning(other.gameObject.name);
                for (int i = 0; i < 25; i++)
                {
                    var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    go.GetComponent<Renderer>().material.color = Color.red;

                    go.transform.position = transform.position + Random.insideUnitSphere * 2 + Vector3.up * 2;
                    go.AddComponent<Rigidbody>();
                    var rb = go.GetComponent<Rigidbody>();
                    rb.mass = 0.01f;
                    rb.useGravity = false;
                    rb.AddForce(Vector3.up);
                    Destroy(go, 6f);
                }
            }
        }
    }
}
