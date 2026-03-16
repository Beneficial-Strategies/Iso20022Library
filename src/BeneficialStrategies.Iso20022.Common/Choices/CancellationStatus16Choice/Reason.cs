// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus16Choice
{
    /// <summary>
    /// Specifies the reason of the cancellation status.
    /// </summary>
    [IsoId("_Do2eSTw6EeW3QqUkIQtIUA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : CancellationStatus16Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_ELEagTw6EeW3QqUkIQtIUA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason23Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_ELEaiTw6EeW3QqUkIQtIUA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
