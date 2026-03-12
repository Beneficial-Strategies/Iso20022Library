// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OwnershipType3Choice
{
    /// <summary>
    /// Owner type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_pl-wkIzhEemXJvzC2Wyt1g")]
    [DisplayName("Code")]
    public partial record Code : OwnershipType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of account ownership.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountOwnershipType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
