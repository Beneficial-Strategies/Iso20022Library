// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxExemptionReasonFormat1Choice
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_4julQ-5oEemXBpiFxCCWFQ")]
    [DisplayName("Structured")]
    public record Structured : TaxExemptionReasonFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required TaxExemptReason1Code Value { get; init; }
    }
}
