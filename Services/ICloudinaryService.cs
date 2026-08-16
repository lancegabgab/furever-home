using CloudinaryDotNet.Actions;

namespace FureverHome.Services
{
    public interface ICloudinaryService
    {
        Task<ImageUploadResult> UploadImageAsync( IFormFile file, string folder);

        Task<bool> DeleteImageAsync(string publicId);
    }
}
