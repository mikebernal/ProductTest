using System.Collections.Generic;
using System.Threading.Tasks;
using ProductTest.Models;

namespace ProductTest.Data
{
    public interface IBulkUpload
    {
        Task<List<SkuTest>> UploadSku(List<SkuTest> skus);
        Task<List<PatternTest>> UploadPattern(List<PatternTest> patterns);
    }
}