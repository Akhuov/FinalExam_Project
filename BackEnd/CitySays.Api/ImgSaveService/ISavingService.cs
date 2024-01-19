namespace CitySays.Api.ImgSaveService
{
    public interface ISavingService
    {
        public ValueTask<string> CreateAvatarAsync(IFormFile formFile);
    }
}
