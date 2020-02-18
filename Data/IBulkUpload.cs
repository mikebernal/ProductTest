using System.Collections.Generic;
using System.Threading.Tasks;
using ProductTest.Models;

namespace ProductTest.Data
{
    public interface IBulkUpload
    {
        Task<List<SkuTest>> Upload(List<SkuTest> skus);
    }
}