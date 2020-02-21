using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductTest.Data;
using ProductTest.Models;

namespace ProductTest.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UploadController : ControllerBase
  {
    private readonly IBulkUpload _bulk;
    public UploadController(IBulkUpload bulk)
    {
      _bulk = bulk;
    }

    // localhost:5000/api/upload/sku
    [HttpPost("sku")]
    
    public async Task<IActionResult> UploadSku(List<SkuTest> skus)
    {
      await _bulk.UploadSku(skus);
      return StatusCode(201);
    }

    // localhost:5000/api/upload/pattern
    [HttpPost("pattern")]
    
    public async Task<IActionResult> UploadPattern(List<PatternTest> patterns)
    {
      await _bulk.UploadPattern(patterns);
      return StatusCode(201);
    }

  }
}
