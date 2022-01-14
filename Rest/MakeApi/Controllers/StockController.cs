
using System;
using System.Collections.Generic;
using MakeApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MakeApi.Controllers {

[ApiController]
[Route("/api/")]
public class StockController : ControllerBase
{
       private static readonly Stock[] stocks = new[] {
        new Stock(1, "MSFT"),
        new Stock(2, "AMZN"),
        new Stock(3, "FB")
    };

    private readonly ILogger<StockController> _logger;

    public StockController(ILogger<StockController> logger) => _logger = logger;

    [HttpGet]
    public IEnumerable<Stock> Get() {
        return stocks;
    }
}

} //namespace ends