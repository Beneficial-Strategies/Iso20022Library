// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundParameters4Choice
{
    /// <summary>
    /// Specifies that there is no criteria for the report. The request is a request for all reports, rather than reports attributed to a specific fund manager, date or financial instrument.
    /// </summary>
    [IsoId("_KQCmFWomEeipaMTLlhaKMQ")]
    [DisplayName("No Criteria")]
    public record NoCriteria : FundParameters4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no criteria.
        /// </summary>
        [IsoXmlTag("NoCrit")]
        public required NoCriteria1Code Value { get; init; }
    }
}
