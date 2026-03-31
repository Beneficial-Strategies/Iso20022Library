// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason9Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [IsoId("_QhPsxz9qEeCY7potQsO_IA")]
    [DisplayName("Code")]
    public record Code : CancellationReason9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the underlying reason for the cancellation of the associated transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancelledStatusReason12Code Value { get; init; }
    }
}
