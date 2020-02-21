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

    public async Task<List<PatternTest>> UploadPattern(List<PatternTest> patterns)
    {
      var existingPatterns = await _context.Patterns.Where(x => x.Title == x.Title).ToListAsync();
      _context.RemoveRange(existingPatterns);
      await _context.SaveChangesAsync();
      await _context.Patterns.AddRangeAsync(patterns);
      await _context.SaveChangesAsync();
      return patterns;
    }

    public async Task<List<SkuTest>> UploadSku(List<SkuTest> skus)
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