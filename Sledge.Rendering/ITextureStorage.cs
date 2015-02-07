using System.Drawing;
using Sledge.Common;

namespace Sledge.Rendering
{
    public interface ITextureStorage
    {
        Texture Create(string name);
        Texture Create(string name, Bitmap bitmap, int width, int height, TextureFlags flags);
        void Bind(string name);
        bool Exists(string name);
        Texture Get(string name);
        void Delete(string name);
        void DeleteAll();
    }
}