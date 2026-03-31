// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationActionReason1Choice
{
    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    public record Code : InvestigationActionReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalInvestigationActionReason1Code Value { get; init; }
    }
}
