using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_taller_pi_1__2_.Areas.Model;
using asp_taller_pi_1__2_.Data;

namespace asp_taller_pi_1__2_.Areas.Identity.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly asp_taller_pi_1__2_.Data.Db_Context1 _context;

        public IndexModel(asp_taller_pi_1__2_.Data.Db_Context1 context)
        {
            _context = context;

            
        }

        public IList<Format> Format { get;set; }

        //_context.Users.ToList();

        public async Task OnGetAsync()
        {
           


            
            Format = await _context.Format.ToListAsync();
            fillFormat();
        }

        public void fillFormat()
        {
            Format = new List<Format>();
            int c = 0;
            _context.Users.ToList().ForEach(u => {
                Format.Add(new Format());
                
                Format[c].UserNamed=u.UserName;
                Format[c].firstName = u.firstName;
                Format[c].LastName = u.LastName;
                Format[c].BirthDate = u.BirthDate;
                c++;
            });
        }
    }
}
