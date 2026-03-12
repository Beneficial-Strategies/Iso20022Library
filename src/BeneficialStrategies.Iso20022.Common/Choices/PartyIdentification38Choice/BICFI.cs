// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification38Choice
{
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_6VaZYeaQEd-q8fx_Zl_34A")]
    [DisplayName("BICFI")]
    public partial record BICFI : PartyIdentification38Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("BICFI")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public required IsoBICFIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
