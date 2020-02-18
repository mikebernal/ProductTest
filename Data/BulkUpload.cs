using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductTest.Models;

namespace ProductTest.Data
{
  public class BulkUpload : IBulkUpload
  {
    private readonly DataContext _context;
    public BulkUpload(DataContext context)
    {
      _context = context;
    }

    public async Task<List<SkuTest>> Upload(List<SkuTest> skus)
    {
      var existingSkus = await _context.Skus.Where(x => x.Sku == x.Sku).ToListAsync();
      _context.RemoveRange(existingSkus);
      await _context.SaveChangesAsync();
      await _context.Skus.AddRangeAsync(skus);
      await _context.SaveChangesAsync();
      return skus;
    }
  }
}