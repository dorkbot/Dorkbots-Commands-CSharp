using Signals;
using UnityEngine;

namespace Dorkbots.UI
{
    [RequireComponent(typeof(Collider))]
    public class Button3D : MonoBehaviour
    {
        public Signal<Button3D> mouseUpSignal { get; private set; }
        public Signal<Button3D> mouseDownSignal { get; private set; }

        private bool perform = true;

        private void Awake()
        {
            mouseUpSignal = new Signal<Button3D>();
            mouseDownSignal = new Signal<Button3D>();
        }

        void OnMouseDown()
        {
            if (perform) mouseDownSignal.Dispatch(this);
        }

        private void OnMouseUp()
        {
            if (perform) mouseUpSignal.Dispatch(this);
        }

        void OnEnable()
        {
            perform = true;
        }

        void OnDisable()
        {
            perform = false;
        }
    }
}