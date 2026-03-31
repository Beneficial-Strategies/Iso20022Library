// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason31Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_m1D9cRUIEeuZw7VHHgrHLg")]
    [DisplayName("Code")]
    public record Code : UnmatchedReason31Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnmatchedReason16Code Value { get; init; }
    }
}
