// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TargetMarket5Choice
{
    /// <summary>
    /// Specifies how the financial product is in scope of the target market parameter.
    /// </summary>
    [IsoId("_xfZQEbVLEeqkjqDuFVh1-A")]
    [DisplayName("Type")]
    public record Type : TargetMarket5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investor.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required InvestorType4Code Value { get; init; }
    }
}
