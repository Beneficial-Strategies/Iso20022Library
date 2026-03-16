// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification19Choice
{
    /// <summary>
    /// Identification of the party expressed as a BIC and an alternative identifier.
    /// </summary>
    [IsoId("_Sp1N7AEcEeCQm6a_G2yO_w_-2022190925")]
    [DisplayName("Any BIC")]
    public record AnyBIC : PartyIdentification19Choice_
    {
        /// <summary>
        /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("AnyBIC")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Value { get; init; }

        /// <summary>
        /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
        /// </summary>
        [IsoId("_Sp1N7wEcEeCQm6a_G2yO_w_1948112368")]
        [DisplayName("Alternative Identifier")]
        [IsoXmlTag("AltrntvIdr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [MinLength(0)]
        [MaxLength(10)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public SimpleValueList<System.String> AlternativeIdentifier { get; init; } = [];
    }
}
