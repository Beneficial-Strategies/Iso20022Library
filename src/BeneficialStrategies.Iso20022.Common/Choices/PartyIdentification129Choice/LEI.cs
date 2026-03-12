// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification129Choice
{
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_TRuNgLXLEeiTob_PrFFUxA")]
    [DisplayName("LEI")]
    public partial record LEI : PartyIdentification129Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Legal Entity Identifier is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
