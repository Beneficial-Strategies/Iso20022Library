// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement9Choice
{
    /// <summary>
    /// Identifies the statement/report that was requested.
    /// </summary>
    [IsoId("_9s0fRdBxEeihG9bKfarOOA")]
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement9Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_9PiekUAlEeWE6OHCSJh8BQ")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber5Choice_ Number { get; init; }
    }
}
