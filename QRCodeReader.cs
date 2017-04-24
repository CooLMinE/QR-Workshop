using System.Drawing;
using ZXing;

namespace QR_Workshop
{
    internal class QRCodeReader
    {
        private readonly BarcodeReader barcodeReader = new BarcodeReader();

        public QRCodeReader()
        {
            barcodeReader.AutoRotate = true;
            barcodeReader.Options.TryHarder = true;
            barcodeReader.TryInverted = true;
        }

        /// <summary>
        ///     Decode the QR code and return the string.
        /// </summary>
        /// <param name="bitmap">The bitmap object to decode.</param>
        /// <returns>Returns a string if the bitmap has been successfully decoded else it throws a NullReferenceException </returns>
        /// <exception cref="System.NullReferenceException">NullReferenceException is thrown when the bitmap could not be decoded.</exception>
        public string Decode(Bitmap bitmap)
        {
            return barcodeReader.Decode(bitmap).Text;
        }
    }
}