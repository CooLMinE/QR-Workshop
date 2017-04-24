using System;
using System.Drawing;
using ZXing;

namespace QR_Workshop
{
    internal class QRCodeGenerator
    {
        private readonly BarcodeWriter barcodeWriter = new BarcodeWriter();

        public QRCodeGenerator()
        {
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            barcodeWriter.Options.Margin = 0;
        }

        /// <summary>
        ///     Generates a bitmap object that holds the QR code.
        /// </summary>
        /// <param name="width">The width of the bitmap.</param>
        /// <param name="height">The height of the bitmap.</param>
        /// <param name="text">The text to encode in the QR code.</param>
        /// <returns>Returns a bitmap with the argument text encoded in it.</returns>
        /// <exception cref="System.ArgumentException">
        ///     ArgumentException is thrown when the value of width or height is lower than
        ///     1.
        /// </exception>
        public Bitmap Generate(int width, int height, string text)
        {
            if (width < 1 || height < 1)
                throw new ArgumentException("Width or height value can't be lower than 1.");

            barcodeWriter.Options.Width = width;
            barcodeWriter.Options.Height = height;
            return new Bitmap(barcodeWriter.Write(text));
        }
    }
}