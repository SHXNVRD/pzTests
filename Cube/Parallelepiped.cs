namespace Cube
{
    public class Parallelepiped
    {
        private float _x;
        private float _y;
        private float _z;

        public bool IsCube => _x == _y && _y == _z;

        public Parallelepiped(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public float GetVolume()
            => _x * _y * _z;

        public float GetLongestSide()
            => Math.Max(Math.Max(_x, _y), _z);
    }
}