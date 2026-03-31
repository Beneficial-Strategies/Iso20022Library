// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason15Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_65JxASwiEeOEV5XHD-BKpw")]
    [DisplayName("Code")]
    public record Code : UnmatchedReason15Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required UnmatchedReason10Code Value { get; init; }
    }
}
