using System.IO;
using Microsoft.AspNetCore.Http;
namespace WebAppCoreImage.Models
{
    public static class Utils
    {
        public static string GetExtension(this IFormFile file)
        {
            return Path.GetExtension(file.FileName);
        }
        public static byte[] ToByteArray(this IFormFile file)
        {           
            using (BinaryReader reader = new BinaryReader(file.OpenReadStream()))
            {
                return reader.ReadBytes((int)file.Length);
            }                
        }
    }
}
