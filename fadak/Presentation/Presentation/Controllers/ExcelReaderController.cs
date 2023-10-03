using Application.DTO.ResponseModel;
using Application.Service.MoviesService;
using Application.Service.ResponseService;
using Application.Service.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [AllowAnonymous]
    public class ExcelReaderController : BaseController
    {

        private readonly IMoviesService _moviesService;

        public ExcelReaderController(IResponseService responseService, IMoviesService moviesService) : base(responseService)
        {
            _moviesService = moviesService;
        }
        [HttpPost]
        public async Task<RessponseModel> AddOrUpdateExcelFile(IFormFile file, MoviesEnums.ExcelFileType type)
        {
            var res = await _moviesService.AddOrUpdateByExcelFile(file, type);
            return responseGenerator.Succssed();

        }
    }
}
