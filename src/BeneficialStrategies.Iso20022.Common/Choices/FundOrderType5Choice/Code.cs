// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundOrderType5Choice
{
    /// <summary>
    /// Type of the investment fund order expressed as a code.
    /// </summary>
    [IsoId("_Ix7loV8rEeicg40_9gK9vQ")]
    [DisplayName("Code")]
    public record Code : FundOrderType5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of investment fund transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundOrderType10Code Value { get; init; }
    }
}
