using ETicareAPI.Domain.Entities;
using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;



        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id=Guid.NewGuid(),Name="Product1",Price=100,CreatedDate=DateTime.UtcNow,Stock=10},
            //    new() {Id=Guid.NewGuid(),Name="Product2",Price=200,CreatedDate=DateTime.UtcNow,Stock=20},
            //    new() {Id=Guid.NewGuid(),Name="Product3",Price=300,CreatedDate=DateTime.UtcNow,Stock=30},

            //});
            //var count = await _productWriteRepository.SaveAsync();



            //Product p = await _productReadRepository.GetByIdAsync("61c522bd-cbd3-41bd-8cbf-b7ce4e60c0e0", false);
            //p.Name = "cccccc";
            //await _productWriteRepository.SaveAsync();


            //await _productWriteRepository.AddAsync(new() { Name = "C product", Price = 1500, Stock = 1, CreatedDate = DateTime.UtcNow });
            //await _productWriteRepository.SaveAsync();
            var customerId = Guid.NewGuid();

            await _customerWriteRepository.AddAsync(new() { Name = "ab" ,Id=customerId});

            await _orderWriteRepository.AddAsync(new() { Description = "aa", Address = "aaaa" ,CustomerId=customerId});
            await _orderWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
