// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason31Choice
{
    /// <summary>
    /// Confirmation cancellation reason expressed as a code.
    /// </summary>
    [IsoId("_tr9nkVM4Eear4I4mBVNwZg")]
    [DisplayName("Code")]
    public record Code : CancellationReason31Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why a confirmation is cancelled.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConfirmationCancellationReason1Code Value { get; init; }
    }
}
