using Microsoft.AspNetCore.Mvc;
using PurchaseMS.ApplicationService.Interfaces;
using PurchaseMS.CrossCutting.Dtos;

namespace PurchaseMS.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Route("api/v{version:apiVersion}/purchase")]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseApplicationService _purchaseApplicationService;

        public PurchaseController(IPurchaseApplicationService purchaseApplicationService)
        {
            _purchaseApplicationService = purchaseApplicationService;
        }


        [HttpPost()]
        public async Task<IActionResult> Add(CreatePurchaseDTO purchaseDto)
        {
            var result = await _purchaseApplicationService.Add(purchaseDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
        

        [HttpPost("totalPrice")]
        public async Task<IActionResult> CalculateTotalPrice(CreatePurchaseDTO purchaseDto)
        {
            var result = await _purchaseApplicationService.CalculateTotalPrice(purchaseDto);
            return Ok(result);
        }

        [HttpPost("discount")]
        public async Task<IActionResult> CalculateDiscount(CreatePurchaseDTO purchaseDto)
        {
            var result = await _purchaseApplicationService.CalculateDiscount(purchaseDto);
            return Ok(result);
        }


        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var result = await _purchaseApplicationService.ListAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _purchaseApplicationService.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpGet("list/including")]
        public async Task<IActionResult> ListIncluding()
        {
            var result = await _purchaseApplicationService.ListIncludingAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}/including")]
        public async Task<IActionResult> GetByIdIncludng(int id)
        {
            var result = await _purchaseApplicationService.GetByIdIncludingAsync(id);
            return Ok(result);
        }
    }
}