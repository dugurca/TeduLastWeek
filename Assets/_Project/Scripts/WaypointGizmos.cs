using UnityEngine;

namespace Assets._Project.Scripts
{
    public class WaypointGizmos : MonoBehaviour
    {
        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, 2f);
        }
    }
}
