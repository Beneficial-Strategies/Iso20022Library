// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification178Choice
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, for example, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_UPdGodgxEeipBO1pkKK6zg")]
    [DisplayName("Any BIC")]
    public partial record AnyBIC : PartyIdentification178Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362: 2014 - &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        public required IsoAnyBICDec2014Identifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
