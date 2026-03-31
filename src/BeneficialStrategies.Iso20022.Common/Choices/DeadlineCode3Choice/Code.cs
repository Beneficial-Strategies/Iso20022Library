// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeadlineCode3Choice
{
    /// <summary>
    /// Standard code to specify the reference date of a corporate action.
    /// </summary>
    [IsoId("_XGLR0UGZEeWqy4niLuXETA")]
    [DisplayName("Code")]
    public record Code : DeadlineCode3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the deadline reference of a corporate action.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionDeadline1Code Value { get; init; }
    }
}
