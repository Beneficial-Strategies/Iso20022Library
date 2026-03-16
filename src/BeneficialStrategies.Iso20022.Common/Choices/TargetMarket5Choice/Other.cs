// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TargetMarket5Choice
{
    /// <summary>
    /// Specifies whether the financial product is in scope of the target market parameter.
    /// </summary>
    [IsoId("_xfZQE7VLEeqkjqDuFVh1-A")]
    [DisplayName("Other")]
    public record Other : TargetMarket5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether a financial product is in scope of a target market parameter.
        /// </summary>
        [IsoXmlTag("Othr")]
        public required TargetMarket1Code Value { get; init; }
    }
}
