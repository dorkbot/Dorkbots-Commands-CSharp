using UnityEngine;

namespace Dorkbots.UI
{
	[RequireComponent(typeof(Collider2D))]
	public class DragObject : MonoBehaviour 
	{
		private Vector3 screenPoint;
		private Vector3 offset;
		private Vector3 curScreenPoint;
		private Vector3 curPosition;

        private bool perform = true;

		void OnMouseDown() 
		{
            if (perform) offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
		}

		void OnMouseDrag()
		{
            if (perform)
            {
                curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
                curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
                transform.position = curPosition;  
            }
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