using UnityEngine;

namespace Unit
{
    public class ClassicInput : IInput
    {
        private const string HorizontalAxisName = "Horizontal";
        private const string VerticalAxisName = "Vertical";

        public Vector2 Axies => GetInputAxies();

        private Vector2 GetInputAxies()
        {
            Vector2 axies = Vector2.zero;

            axies.x = Input.GetAxis(HorizontalAxisName);
            axies.y = Input.GetAxis(VerticalAxisName);

            return axies;
        }
    }
}
