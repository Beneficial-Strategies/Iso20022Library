// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralValueCriteriaDefinition4Choice
{
    /// <summary>
    /// New Criteria.
    /// </summary>
    [DisplayName("New Criteria")]
    public record NewCriteria : CollateralValueCriteriaDefinition4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NewCrit")]
        public required CollateralValueCriteria4 Value { get; init; }
    }
}
