// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DistributionTypeFormat7Choice
{
    /// <summary>
    /// Standard code to specify whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
    /// </summary>
    [IsoId("_4xLzIUEFEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : DistributionTypeFormat7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DistributionType3Code Value { get; init; }
    }
}
