// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement9Choice
{
    /// <summary>
    /// Identifies the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_9s0fQ9BxEeihG9bKfarOOA")]
    [DisplayName("Status Advice")]
    [IsoXmlTag("StsAdvc")]
    public record StatusAdvice : StatusOrStatement9Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_9JOC9dBxEeihG9bKfarOOA")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber5Choice_ Number { get; init; }

        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_9JOC_dBxEeihG9bKfarOOA")]
        [DisplayName("References")]
        [IsoXmlTag("Refs")]
        public ValueList<Identification26> References { get; init; } = [];
        // ID for the above is _9JOC_dBxEeihG9bKfarOOA
    }
}
