using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CPS2.Models;

namespace CPS.Controllers
{

    [Route("api")]
    [ApiController]
    public class CPSController : Controller
    {
        private CpsContext CpsContext;

        public CPSController(CpsContext cpscontext)
        {
            CpsContext = cpscontext;
        }
        ///  All get methods
        //Commidity price source get method
        [HttpGet]
        [Route("getcommiditypricesource")]
        public IEnumerable<Cp> Getcps()
        {
            return CpsContext.Cps;
        }
        //FX Rate Source get method
        [HttpGet]
        [Route("getfxratesetup")]
        public IEnumerable<Fxr> Getfxr()
        {
            return CpsContext.Fxrs;
        }
        // Energy conversion Factor Setup get method
        [HttpGet]
        [Route("getenergyconversionfactor")]
        public IEnumerable<Ecfsetup> Getecf()
        {
            return CpsContext.Ecfsetups;
        }
        //Holiday Calendar setup get method
        [HttpGet]
        [Route("getholidaycalendersetup")]
        public IEnumerable<Holidaycalendersetup> Gethcs()
        {
            return CpsContext.Holidaycalendersetups;
        }

        //Commidity Price Source Post Method 
        [HttpPost]
        [Route("postcommiditypricesource")]
        public void Post([FromBody] Cp value)
        {
            CpsContext.Cps.Add(value);
            CpsContext.SaveChanges();
        }
        // Energy conversion Factor Setup Post Method
        [HttpPost]
        [Route("postenergyconversionfactor")]
        public void Postecf([FromBody] Ecfsetup value)
        {
            CpsContext.Ecfsetups.Add(value);
            CpsContext.SaveChanges();
        }
        //FX Rate Source Post method
        [HttpPost]
        [Route("postfxratesetup")]
        public void Postfxr([FromBody] Fxr value)
        {
            CpsContext.Fxrs.Add(value);
            CpsContext.SaveChanges();
        }
        //Holiday calender setup Post method
        [HttpPost]
        [Route("postholidaycalendersetup")]
        public void Posthcs([FromBody] Holidaycalendersetup value)
        {
            CpsContext.Holidaycalendersetups.Add(value);
            CpsContext.SaveChanges();
        }

        //Commidity Price Source getby{id} method
        [HttpGet("getcommiditypricesource/{id}")]
         public Cp Getbyidcps(int id)
         {
             return CpsContext.Cps.FirstOrDefault(s => s.Id == id);
         }

         //FX Rate Source getby{id} method
        [HttpGet("getfxratesetup/{id}")]
        public Fxr Getbyidfxr(int id)
        {
            return CpsContext.Fxrs.FirstOrDefault(k => k.Id == id);
        }

        //Energy Convension Factor Setup getby{id} method
        [HttpGet("getenergyconversionfactor/{id}")]
        public Ecfsetup Getbyidecf(int id)
        {
            return CpsContext.Ecfsetups.FirstOrDefault(s => s.Id == id);
        }
        //Holiday calender Setup getby{id} method
        [HttpGet("getholidaycalendersetup/{id}")]
        public Holidaycalendersetup Getbyidhcs(int id)
        {
            return CpsContext.Holidaycalendersetups.FirstOrDefault(s => s.Id == id);
        }
        //Commidity Price Source put method
         [HttpPut("putcommiditypricesource/{id}")]
         public void Putcps(int id, [FromBody] Cp value)
         {
             var cps = CpsContext.Cps.FirstOrDefault(s => s.Id == id);
             if (cps != null)
             {
                 CpsContext.Entry<Cp>(cps).CurrentValues.SetValues(value);
                 CpsContext.SaveChanges();
             }
         }
        //FX Rate Source put method
        [HttpPut("putfxratesetup/{id}")]
        public void Putfxr(int id, [FromBody] Cp value)
        {
            var fxr = CpsContext.Fxrs.FirstOrDefault(s => s.Id == id);
            if (fxr != null)
            {
                CpsContext.Entry<Fxr>(fxr).CurrentValues.SetValues(value);
                CpsContext.SaveChanges();
            }
        }
        //Energy Convension Factor Setup put method
        [HttpPut("putenergyconversionfactor/{id}")]
        public void Putecf(int id, [FromBody] Ecfsetup value)
        {
            var ecf = CpsContext.Ecfsetups.FirstOrDefault(s => s.Id == id);
            if (ecf != null)
            {
                CpsContext.Entry<Ecfsetup>(ecf).CurrentValues.SetValues(value);
                CpsContext.SaveChanges();
            }
        }
        //Holiday calender Setup put method
        //PUT: api/putholidaycalendersetup/{id}
        [HttpPut("putholidaycalendersetup/{id}")]
        public void Puthcs(int id, [FromBody] Ecfsetup value)
        {
            var hcs = CpsContext.Holidaycalendersetups.FirstOrDefault(s => s.Id == id);
            if (hcs != null)
            {
                CpsContext.Entry<Holidaycalendersetup>(hcs).CurrentValues.SetValues(value);
                CpsContext.SaveChanges();
            }
        }
    }
}
