using EnterTheBuilding.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterTheBuilding.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntryController : Controller
    {

        [HttpGet]
        public IEnumerable<TblEntryoff> Get()

        {

            try
            {
                using (BuildingContext Context= new BuildingContext())
                {
                    return Context.TblEntryoffs.ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        [HttpGet("{Id}")]
        public TblEntryoff Get(int Id = 0)
        {

            try
            {
                using (BuildingContext Context = new BuildingContext())
                {
                    return Context.TblEntryoffs.FirstOrDefault(e => e.Id == Id);
                }

            }
            catch (Exception ex)
            {

                throw ex;
                // return "no data";
            }
        }
            [HttpPost]
            public string Post([FromBody] TblEntryoff tblEntryoff)
            {

                try
                {
                    //  WebapiContext context = new WebapiContext();
                    using (BuildingContext Context = new BuildingContext())
                    {
                        Context.TblEntryoffs.Add(tblEntryoff);
                        Context.SaveChanges();
                        return "success ";
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }

        }
    }

