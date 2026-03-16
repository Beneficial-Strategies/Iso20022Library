// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord7Choice
{
    /// <summary>
    /// Valuation.
    /// </summary>
    [DisplayName("Valuation")]
    public record Valuation : InvestigationDataRecord7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Valtn")]
        public required AdjustmentCompensation1 Value { get; init; }
    }
}
