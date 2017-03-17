using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class ViewRepository : EFRepository<View>, IViewRepository
	{

	}

	public  interface IViewRepository : IRepository<View>
	{

	}
}