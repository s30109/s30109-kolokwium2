using Microsoft.AspNetCore.Localization;
using WebApplication1.DTO;

namespace WebApplication1.Service;

public interface IDbService
{
    Task<CustomerDto> GetOrdersByCustomerId(int customerId);
}