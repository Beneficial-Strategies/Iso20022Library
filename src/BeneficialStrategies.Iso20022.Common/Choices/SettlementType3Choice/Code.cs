// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementType3Choice
{
    /// <summary>
    /// Settlement type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_2f4SEeLbEeWFtOV72FbX9w")]
    [DisplayName("Code")]
    public partial record Code : SettlementType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates how an option trade is settled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
