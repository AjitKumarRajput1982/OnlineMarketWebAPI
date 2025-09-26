using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarketWebAPI.DataBaseContext;
using OnlineMarketWebAPI.Models;

namespace OnlineMarketWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public CarController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("getcarbrand")]
        public async Task<ActionResult<IEnumerable<Carbrand>>> getcarbrand()
        {            
            var carbrand = await _dbContext.carbrands.OrderBy(temp => temp.CarBrandID).ToListAsync();
            return carbrand;
        }

        [HttpGet("getcarbudget")]
        public async Task<ActionResult<IEnumerable<Carbudget>>> getcarbudget()
        {            
            var carbudget = await _dbContext.carbudget.OrderBy(temp => temp.CarBudgetID).ToListAsync();
            return carbudget;
        }

        [HttpGet("getcarfuel")]
        public async Task<ActionResult<IEnumerable<Carfuel>>> getcarfuel()
        {
            var carfuel = await _dbContext.carfuel.OrderBy(temp => temp.CarFuelID).ToListAsync();
            return carfuel;
        }

        [HttpGet("getcarkmdriven")]
        public async Task<ActionResult<IEnumerable<Carkmdriven>>> getcarkmdriven()
        {
            var carkmdriven = await _dbContext.carkmdriven.OrderBy(temp => temp.CarKMDrivenID).ToListAsync();
            return carkmdriven;
        }

        [HttpGet("getcarnoofowner")]
        public async Task<ActionResult<IEnumerable<Carnoofowner>>> getcarnoofowner()
        {
            var carnoofowner = await _dbContext.carnoofowner.OrderBy(temp => temp.CarNoOfOwnerID).ToListAsync();
            return carnoofowner;
        }
        
        [HttpGet("getcarstate")]
        public async Task<ActionResult<IEnumerable<State>>> getcarstate()
        {
            var state = await _dbContext.state.OrderBy(temp => temp.StateID).ToListAsync();
            return state;
        }
    } 
}
