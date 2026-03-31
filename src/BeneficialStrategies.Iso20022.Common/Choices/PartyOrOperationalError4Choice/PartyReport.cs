// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError4Choice
{
    /// <summary>
    /// Party Report.
    /// </summary>
    [DisplayName("Party Report")]
    public record PartyReport : PartyOrOperationalError4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PtyRpt")]
        public required PartyReport4 Value { get; init; }
    }
}
