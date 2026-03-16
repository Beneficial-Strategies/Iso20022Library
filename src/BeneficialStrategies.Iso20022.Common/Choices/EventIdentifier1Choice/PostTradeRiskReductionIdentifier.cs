// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EventIdentifier1Choice
{
    /// <summary>
    /// Specifies post trade risk reduction identifier.
    /// </summary>
    [IsoId("_tbdG8PbfEeyInphUKJZxtQ")]
    [DisplayName("Post Trade Risk Reduction Identifier")]
    public record PostTradeRiskReductionIdentifier : EventIdentifier1Choice_
    {
        /// <summary>
        /// Identification of the structurer of the post trade risk reduction identifier.
        /// </summary>
        [IsoId("_-UxsID1hEeyA3eIPELln4g")]
        [DisplayName("Structurer")]
        [IsoXmlTag("Strr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Structurer { get; init; }

        /// <summary>
        /// Post trade risk reduction identifier assigned by the structurer allowing to link the constituents.
        /// </summary>
        [IsoId("_GT9wQD1iEeyA3eIPELln4g")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text Identification { get; init; }
    }
}
