using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QR_Workshop
{
    public partial class MainWindow : XtraForm
    {
        private readonly QRCodeGenerator qrGenerator = new QRCodeGenerator();
        private readonly QRCodeReader qrReader = new QRCodeReader();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textEditQRFileLocationDecode_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void textEditQRFileLocationDecode_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                textEditQRFileLocationDecode.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void simpleButtonDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditQRFileLocationDecode.Text))
                MessageBox.Show("Please select a file to decode.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!File.Exists(textEditQRFileLocationDecode.Text))
                MessageBox.Show("The file you have selected does not exist. Please select another file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                memoEditDecodeResult.Text = string.Empty;
                try
                {
                    memoEditDecodeResult.Text = qrReader.Decode((Bitmap) Image.FromFile(textEditQRFileLocationDecode.Text));
                }
                catch
                {
                    memoEditDecodeResult.Text = "The QR code image is not valid.";
                }
            }
        }

        private void simpleButtonSelectImageDecode_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                    textEditQRFileLocationDecode.Text = ofd.FileName;
            }
        }

        private void simpleButtonQRGenerate_Click(object sender, EventArgs e)
        {
            int width;
            int height;

            if (!int.TryParse(textEditQRWidth.Text, out width) || !int.TryParse(textEditQRHeight.Text, out height))
                MessageBox.Show(@"The width or height values are not valid.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (width < 1 || height < 1)
                MessageBox.Show(@"The width and height values need to be greater than 0.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(memoEditQRContent.Text))
                MessageBox.Show(@"Content text is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = @"PNG file (*.png) | *.png | JPG file (*.jpg) | *.jpg";
                    if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                    {
                        ImageFormat imf;
                        var ext = Path.GetExtension(sfd.FileName).Trim('.').ToLower().Trim();

                        switch (ext)
                        {
                            case "jpg":
                                imf = ImageFormat.Jpeg;
                                break;
                            case "png":
                                imf = ImageFormat.Png;
                                break;
                            default:
                                imf = ImageFormat.Png;
                                break;
                        }

                        qrGenerator.Generate(width, height, memoEditQRContent.Text).Save(sfd.FileName, imf);
                    }
                }
            }
        }
    }
}