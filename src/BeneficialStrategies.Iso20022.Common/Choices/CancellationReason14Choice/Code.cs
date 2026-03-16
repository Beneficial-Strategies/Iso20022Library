// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason14Choice
{
    /// <summary>
    /// Reason for the cancellation request, in a coded form.
    /// </summary>
    [IsoId("_t3j1IVkyEeGeoaLUQk__nA_2050646614")]
    [DisplayName("Code")]
    public record Code : CancellationReason14Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for requesting the cancellation of a payment instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CancellationReason5Code Value { get; init; }
    }
}
