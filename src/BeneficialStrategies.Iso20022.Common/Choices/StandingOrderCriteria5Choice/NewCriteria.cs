// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderCriteria5Choice
{
    /// <summary>
    /// New Criteria.
    /// </summary>
    [DisplayName("New Criteria")]
    public record NewCriteria : StandingOrderCriteria5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NewCrit")]
        public required StandingOrderCriteria5 Value { get; init; }
    }
}
