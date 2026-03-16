// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus7Choice
{
    /// <summary>
    /// Specifies the reason of the CancellationStatus.
    /// </summary>
    [IsoId("_nR4Iof5DEeClUvPNHKL9Zw")]
    [DisplayName("Reason")]
    public record Reason : CancellationStatus7Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_nR4Ir_5DEeClUvPNHKL9Zw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason12Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_nR4Iuf5DEeClUvPNHKL9Zw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
