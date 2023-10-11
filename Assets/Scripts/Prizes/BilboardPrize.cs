using UnityEngine;

namespace MetaYouGo.Scripts.Prizes
{
    public class BilboardPrize : MonoBehaviour
    {
        private Camera m_Camera;
    
        void Start()
        {
            m_Camera = Camera.main;
        }
    
        void LateUpdate()
        {
            transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
                m_Camera.transform.rotation * Vector3.up);
            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.x = 0;
            eulerAngles.z = 0;
            transform.eulerAngles = eulerAngles;
        }
    }
}