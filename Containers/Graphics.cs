using System.Drawing;
namespace graphics
{

	public class Image : jumpE_basic.CustTypeName
	{
		
		Bitmap self = new Bitmap(64,64);
		public Image()
		{
			
		}
		public string name(){return "image";}
		public Image(int S)
		{
			self = new Bitmap(S,S);
		}
		public Image(int W,int H)
		{
			self = new Bitmap(W,H);
		}
		public Image(byte[,,] im)
		{
			self = ArrayToImage(im);
		}
		public static Bitmap ArrayToImage(byte[,,] pixelArray)
		{
			int width = pixelArray.GetLength(1);
			int height = pixelArray.GetLength(0);
			int stride = (width % 4 == 0) ? width : width + 4 - width % 4;
			int bytesPerPixel = 3;

			byte[] bytes = new byte[stride * height * bytesPerPixel];
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					int offset = (y * stride + x) * bytesPerPixel;
					bytes[offset + 0] = pixelArray[y, x, 2]; // blue
					bytes[offset + 1] = pixelArray[y, x, 1]; // green
					bytes[offset + 2] = pixelArray[y, x, 0]; // red
				}
			}

			PixelFormat formatOutput = PixelFormat.Format24bppRgb;
			Rectangle rect = new(0, 0, width, height);
			Bitmap bmp = new(stride, height, formatOutput);
			BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadOnly, formatOutput);
			Marshal.Copy(bytes, 0, bmpData.Scan0, bytes.Length);
			bmp.UnlockBits(bmpData);

			Bitmap bmp2 = new(width, height, PixelFormat.Format32bppPArgb);
			Graphics gfx2 = Graphics.FromImage(bmp2);
			gfx2.DrawImage(bmp, 0, 0);

			return bmp2;
		}
		
	}

}