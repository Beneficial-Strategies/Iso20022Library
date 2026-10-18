// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason19Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    [IsoId("_8NNHKytXEeyhipY4f42fZQ")]
    [DisplayName("Unmatched Reason")]
    public record UnmatchedReason : Reason19Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("UmtchdRsn")]
        public required UnmatchedReason22Choice_ Value { get; init; }
    }
}
