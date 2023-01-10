//using gChartRazor.NW;
using gChartRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace gChartRazor.Pages
{

    public class ChartDataModel : PageModel
    {
        private readonly ILogger<ChartDataModel> _logger;
        private readonly TestDbContext _TestDbContext;

        public ChartDataModel(ILogger<ChartDataModel> logger, TestDbContext testDbContext)
        {
            _logger = logger;
            _TestDbContext = testDbContext;
        }

        public async Task<JsonResult> OnGet()
        {
          var query = await _TestDbContext.TblData.OrderByDescending(x => x.Id).Take(600).ToListAsync();
            List<TblDatum2> liste2 = new List<TblDatum2>();
            foreach (var item in query)
            {
                liste2.Add(new TblDatum2 { Id = item.Id,Tarih=item.Tarih ,Tx= Convert.ToInt32(item.Tx), Rx=Convert.ToInt32(item.Rx) });

            }
            return new JsonResult(liste2.OrderBy(x => x.Id));
        }
    }
}