using FarmEquipmentTracker.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FarmEquipmentTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly MachineDbContext _MachineDbContext;
        
        public MachineController(MachineDbContext machineDbContext)
        {
            _MachineDbContext = machineDbContext;
        }
        [HttpGet]
        [Route("GetMachine")]
        public async Task<IEnumerable<Machine>> GetMachines()
        {
            return await _MachineDbContext.Machine.ToListAsync();

        }
        [HttpPost]
        [Route("AddMachine")]
        public async Task<Machine> AddMachine(Machine objMachine)
        {
            _MachineDbContext.Machine.Add(objMachine);
            await _MachineDbContext.SaveChangesAsync();
            return objMachine;
        }
        [HttpPatch]
        [Route("UpdateMachine/{id}")]
        public async Task<Machine> UpdateMachine(Machine objMachine)
        {
            _MachineDbContext.Entry(objMachine).State = EntityState.Modified;
            await _MachineDbContext.SaveChangesAsync();
            return objMachine;
        }
        [HttpPatch]
        [Route("UpdateInYard/{id}")]
        public async Task<Machine> UpdateInYard(Machine objMachine)
        {
            _MachineDbContext.Entry(objMachine).State = EntityState.Modified;
            await _MachineDbContext.SaveChangesAsync();
            return objMachine;
        }

        [HttpDelete]
        [Route("DeleteMachine/{id}")]
        public bool DeleteMachine(int id)
        {
            bool a = false;
            var machine = _MachineDbContext.Machine.Find(id);
            if (machine != null)
            {
                a = true;
                _MachineDbContext.Entry(machine).State = EntityState.Deleted;
                _MachineDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;



        }

    }
}
