using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
   public class Tenants
    {
        
/// <summary>
/// 
/// </summary>
/// <param name="userId"></param>
/// <returns></returns>

        public List<Models.BD.Tenants> GetTenants(String userId)
        {
            DAL.Models.ProjectCoreContext _context = new DAL.Models.ProjectCoreContext();

            //Linq
            var listTenants = (from _tenants in _context.Tenants
                               join _aspNetUsers in _context.AspNetUsers
                               on _tenants.Id equals _aspNetUsers.TenantId
                               where _aspNetUsers.Id.Equals(userId)
                               select new Models.BD.Tenants
                               {

                                   Id = _tenants.Id,
                                   Name = _tenants.Name,
                                   Plan = _tenants.Plan,
                                   CreatedAt = _tenants.CreatedAt,
                                   UpdatedAt = _tenants.UpdatedAt
    
                              
                              }).ToList();


            return listTenants;

        }


    }
}
