// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemMemberStatus1Choice
{
    /// <summary>
    /// System member status, in a coded form.
    /// </summary>
    [IsoId("_V4OMxXhhEeidzqjNEfehPg")]
    [DisplayName("Code")]
    public partial record Code : SystemMemberStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the live status of a member of a system.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MemberStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
