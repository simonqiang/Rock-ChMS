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

using Rock.Util;

namespace Rock.Rest.Util
{
    /// <summary>
    /// WorkflowTriggers REST API
    /// </summary>
    public partial class WorkflowTriggersController : Rock.Rest.ApiController<Rock.Util.WorkflowTrigger, Rock.Util.WorkflowTriggerDto>
    {
        public WorkflowTriggersController() : base( new Rock.Util.WorkflowTriggerService() ) { } 
    }
}