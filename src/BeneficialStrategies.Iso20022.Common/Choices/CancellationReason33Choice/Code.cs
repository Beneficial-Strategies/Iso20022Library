// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice
{
    /// <summary>
    /// Reason for the cancellation request, in a coded form.
    /// </summary>
    [IsoId("_wsiMM0gtEeaGKYpLDboHPQ")]
    [DisplayName("Code")]
    public record Code : CancellationReason33Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the cancellation reason, as published in an external cancellation reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalCancellationReason1Code Value { get; init; }
    }
}
