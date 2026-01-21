using FioGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace FioGenerator.Controllers
{
    [Route("TransferSimulator")]
    [ApiController]
    public class FIOController : ControllerBase
    {
        private readonly string[] FioArray =
        {
            "Иванов Иван Иванович",
            "Констант1нов Рома% Андреевич",
            "Дмитриенко Вячеслав Эдуардович",
            "Фам1л1я Им9 От4ество"
        };

        [HttpGet("fullName")]
        public async Task<IActionResult> GetFullName()
        {
            var randomizer = new Random();
            var randomNumber = randomizer.Next(0, FioArray.Length);
            var response = new FioResponseDto { Value = FioArray[randomNumber] };

            return Ok(response);
        }
    }
}
