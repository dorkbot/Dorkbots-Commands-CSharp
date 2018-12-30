using Signals;
using UnityEngine;

namespace Dorkbots.UI
{
	[RequireComponent(typeof(Collider2D))]
	public class Button2D : MonoBehaviour 
	{
        public Signal<Button2D> mouseUpSignal { get; private set; }
        public Signal<Button2D> mouseDownSignal { get; private set; }

        private bool perform = true;

        private void Awake()
        {
            mouseUpSignal = new Signal<Button2D>();
            mouseDownSignal = new Signal<Button2D>();
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