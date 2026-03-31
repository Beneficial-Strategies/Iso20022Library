// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord7Choice
{
    /// <summary>
    /// Compensation.
    /// </summary>
    [DisplayName("Compensation")]
    public record Compensation : InvestigationDataRecord7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Compstn")]
        public required CompensationResponse1 Value { get; init; }
    }
}
