using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					Username="Ela"
				},
				new UserComment
				{
					ID=2,
					Username="Seda"
				},
				new UserComment
				{
					ID=3,
					Username="Elif"
				}
			};
			return View(commentValues);
		}
	}
}
