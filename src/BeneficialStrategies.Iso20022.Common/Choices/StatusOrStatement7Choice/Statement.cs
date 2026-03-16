// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement7Choice
{
    /// <summary>
    /// Identify the statement/report that was requested.
    /// </summary>
    [IsoId("_RMPsVTs-EeWRTLSN0i0tng")]
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement7Choice_
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
