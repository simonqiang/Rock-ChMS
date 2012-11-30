//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Util
{
    /// <summary>
    /// ActivityType Service class
    /// </summary>
    public partial class ActivityTypeService : Service<ActivityType, ActivityTypeDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTypeService"/> class
        /// </summary>
        public ActivityTypeService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTypeService"/> class
        /// </summary>
        public ActivityTypeService(IRepository<ActivityType> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override ActivityType CreateNew()
        {
            return new ActivityType();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<ActivityTypeDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<ActivityTypeDto> QueryableDto( IQueryable<ActivityType> items )
        {
            return items.Select( m => new ActivityTypeDto()
                {
                    IsActive = m.IsActive,
                    WorkflowTypeId = m.WorkflowTypeId,
                    Name = m.Name,
                    Description = m.Description,
                    IsActivatedWithWorkflow = m.IsActivatedWithWorkflow,
                    Order = m.Order,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( ActivityType item, out string errorMessage )
        {
            errorMessage = string.Empty;
            RockContext context = new RockContext();
            context.Database.Connection.Open();

            using ( var cmdCheckRef = context.Database.Connection.CreateCommand() )
            {
                cmdCheckRef.CommandText = string.Format( "select count(*) from WorkflowActivity where ActivityTypeId = {0} ", item.Id );
                var result = cmdCheckRef.ExecuteScalar();
                int? refCount = result as int?;
                if ( refCount > 0 )
                {
                    Type entityType = RockContext.GetEntityFromTableName( "WorkflowActivity" );
                    string friendlyName = entityType != null ? entityType.GetFriendlyTypeName() : "WorkflowActivity";

                    errorMessage = string.Format("This {0} is assigned to a {1}.", ActivityType.FriendlyTypeName, friendlyName);
                    return false;
                }
            }

            return true;
        }
    }
}