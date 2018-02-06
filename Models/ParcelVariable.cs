using System;
namespace Parcel.Models
{
    public class ParcelVariable
    {
        private string _width;
        private string _length;
        private string _height;
        private string _weight;
        private string _volume;

        public string GetWidth()
        {
            return _width;
        }

        public void SetWidth(string newWidth)
        {
            _width = newWidth;
        }

        public string GetLength()
        {
            return _length;
        }

        public void SetLength(string newLength)
        {
            _length = newLength;
        }

        public string GetHeight()
        {
            return _height;
        }

        public void SetHeight(string newHeight)
        {
            _height = newHeight;
        }

        public string GetWeight()
        {
            return _weight;
        }

        public void SetWeight(string newWeight)
        {
            _weight = newWeight;
        }
    }
}
