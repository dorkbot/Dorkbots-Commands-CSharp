using UnityEngine;

namespace Dorkbots.UI
{
    public static class UITools
    {
        /// <summary>
        /// Finds the user's input position in a RectTransform</summary>
        /// <param name="rectTransform">The target RectTransform</param>
        /// <returns>A Vector2 object with the x and y for the position.</returns>
        public static Vector2 GetInputVectorRectTransform(RectTransform rectTransform)
        {
            // Get X and Y position of the users input on the source.
            Rect sourceRect = rectTransform.rect;
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, Input.mousePosition, Camera.main, out localPoint);

            return localPoint;
        }
    }
}