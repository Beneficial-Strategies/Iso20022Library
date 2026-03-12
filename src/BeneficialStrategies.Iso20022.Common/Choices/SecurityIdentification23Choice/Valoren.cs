// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice
{
    /// <summary>
    /// Identifier for Swiss securities assigned by Telekurs Financial, the Swiss numbering agency.
    /// </summary>
    [IsoId("_CSq4RyGQEeW7gKYhAMEFCw")]
    [DisplayName("Valoren")]
    public partial record Valoren : SecurityIdentification23Choice_
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
