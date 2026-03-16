// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus6Choice
{
    /// <summary>
    /// Confirmation.
    /// </summary>
    [DisplayName("Confirmation")]
    public record Confirmation : InvestigationStatus6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required ExternalInvestigationExecutionConfirmation1Code Value { get; init; }
    }
}
