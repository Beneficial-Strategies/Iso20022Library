// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice
{
    /// <summary>
    /// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
    /// </summary>
    [IsoId("_Qd1wkdp-Ed-ak6NoX_4Aeg_-722284808")]
    [DisplayName("Valoren")]
    public partial record Valoren : SecurityIdentification3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
        /// </summary>
        [IsoXmlTag("Vlrn")]
        [IsoSimpleType(IsoSimpleType.ValorenIdentifier)]
        public required IsoValorenIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
