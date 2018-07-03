namespace Parcels.Models
{
    public class Parcel
    {
        private int _height;
        private int _width;
        private int _depth;
        private int _weight;

        public Parcel(int height, int width, int depth, int weight)
        {
            _height = height;
            _width = width;
            _depth = depth;
            _weight = weight;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetDepth(int depth)
        {
            _depth = depth;
        }

        public int GetDepth()
        {
            return _depth;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public  int GetWeight()
        {
            return _weight;
        }

    }
}
