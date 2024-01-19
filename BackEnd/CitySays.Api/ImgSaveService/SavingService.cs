namespace CitySays.Api.ImgSaveService
{
    public class SavingService:ISavingService
    {
        private readonly IWebHostEnvironment _environment;

        public SavingService( IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        //-==-=-=-----------------------------------------------=-=-=-
        public async ValueTask<string> CreateAvatarAsync(IFormFile formFile)
        {
            try
            {

                //var imageItems = formFile.FileName.Split('.');

                var extension = Path.GetExtension(formFile.FileName);

                var path = "E:\\Study\\FinalExam_Project\\BackEnd\\CitySays.Domain\\Images\\" + Guid.NewGuid() + "." + extension;

                string fullPath = _environment.WebRootPath + path;

                using (FileStream file = new FileStream(fullPath, FileMode.Create))
                {
                    await formFile.CopyToAsync(file);
                }

                return path;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
