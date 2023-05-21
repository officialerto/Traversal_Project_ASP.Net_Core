using BusinessLayer.Concrete;
using DataAccessLibrary.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Project_ASP.Net_Core.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationByID(id); 
            return View(values);
        }
    }
}
