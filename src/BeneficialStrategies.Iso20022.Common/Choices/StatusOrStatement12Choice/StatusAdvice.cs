// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement12Choice
{
    /// <summary>
    /// Identifies the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_gBH0ETi8Eeydid5dcNPKvg")]
    [DisplayName("Status Advice")]
    public record StatusAdvice : StatusOrStatement12Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_gBH0HTi8Eeydid5dcNPKvg")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber6Choice_ Number { get; init; }

        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_gBH0JTi8Eeydid5dcNPKvg")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification29> References { get; init; } = [];
        // ID for the above is _gBH0JTi8Eeydid5dcNPKvg
    }
}
