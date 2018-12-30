using UnityEngine;

namespace Dorkbots
{
    public class CameraBillboard : MonoBehaviour
    {
        [SerializeField] private Camera _camera;

        private float zRotation;

        private void Awake()
        {
            zRotation = transform.rotation.z;
        }

        void Start()
        {
            _camera = Camera.main;
        }

        void Update()
        {
            transform.LookAt(transform.position + _camera.transform.rotation * Vector3.forward, _camera.transform.rotation * Vector3.up);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, zRotation);
        }
    }
}