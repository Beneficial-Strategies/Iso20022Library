// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification24Choice
{
    /// <summary>
    /// Market Identifier Code. Identification of a financial market, as stipulated in the norm ISO 10383 &quot;Codes for exchanges and market identifications&quot;.
    /// </summary>
    [IsoId("_QReIhtp-Ed-ak6NoX_4Aeg_246882827")]
    [DisplayName("MIC")]
    public partial record MIC : PartyIdentification24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("MIC")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
