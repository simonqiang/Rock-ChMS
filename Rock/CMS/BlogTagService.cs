//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.CMS
{
	/// <summary>
	/// Blog Tag POCO Service class
	/// </summary>
    public partial class BlogTagService : Service<Rock.CMS.BlogTag>
    {
		/// <summary>
		/// Gets Blog Tags by Blog Id
		/// </summary>
		/// <param name="blogId">Blog Id.</param>
		/// <returns>An enumerable list of BlogTag objects.</returns>
	    public IEnumerable<Rock.CMS.BlogTag> GetByBlogId( int blogId )
        {
            return Repository.Find( t => t.BlogId == blogId );
        }
		
    }
}