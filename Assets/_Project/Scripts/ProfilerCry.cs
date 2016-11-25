using UnityEngine;

namespace Assets._Project.Scripts
{
    public class ProfilerCry : MonoBehaviour
    {
        private Vector3 _v3 = new Vector3(1, 1, 1);
        void Update ()
        {
            Vector3 x = Random.insideUnitSphere;
            for (int i = 0; i < 50000; i++)
            {
                Vector3 v = new Vector3(Random.value, Random.value, Random.value);
                x += v;
            }
            x = Vector3.zero;
            _v3 = x;
            _v3 = Vector3.one;
        }
    }
}
