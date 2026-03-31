// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement8Choice
{
    /// <summary>
    /// Identify the statement/report that was requested.
    /// </summary>
    [IsoId("_8RsziZNLEeWGlc8L7oPDIg")]
    [DisplayName("Statement")]
    public record Statement : StatusOrStatement8Choice_
    {
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_8QbApZNLEeWGlc8L7oPDIg")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        public required DocumentNumber6Choice_ Number { get; init; }
    }
}
