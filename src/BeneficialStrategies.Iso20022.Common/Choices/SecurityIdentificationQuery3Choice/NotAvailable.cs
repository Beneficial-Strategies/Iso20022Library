// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery3Choice
{
    /// <summary>
    /// Query for not available value (N/A).
    /// Usage: N/A means that value was not available at the time of the reporting.
    /// </summary>
    [IsoId("_P-19BdGgEeaQk737TH1Fzw")]
    [DisplayName("Not Available")]
    public record NotAvailable : SecurityIdentificationQuery3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a not available value code.
        /// </summary>
        [IsoXmlTag("NotAvlbl")]
        public required NotAvailable1Code Value { get; init; }
    }
}
