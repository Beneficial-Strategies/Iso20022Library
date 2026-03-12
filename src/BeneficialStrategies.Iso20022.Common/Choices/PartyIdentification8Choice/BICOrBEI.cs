// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification8Choice
{
    /// <summary>
    /// Identification of a party by a BIC and an Alternative Identifier.
    /// </summary>
    [IsoId("_Q7pG4Np-Ed-ak6NoX_4Aeg_1657637865")]
    [DisplayName("BIC Or BEI")]
    public partial record BICOrBEI : PartyIdentification8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("BICOrBEI")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Value { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
        /// </summary>
        [IsoId("_QQkwp9p-Ed-ak6NoX_4Aeg_1555128116")]
        [DisplayName("Alternative Identifier")]
        [IsoXmlTag("AltrntvIdr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(10)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public SimpleValueList<System.String> AlternativeIdentifier { get; init; } = new SimpleValueList<System.String>(){};
        
        
        #nullable disable
        
    }
}
