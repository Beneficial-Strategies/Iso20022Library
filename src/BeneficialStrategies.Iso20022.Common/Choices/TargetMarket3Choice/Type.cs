// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TargetMarket3Choice
{
    /// <summary>
    /// Specifies how a financial product is in scope of the target market parameter.
    /// </summary>
    [IsoId("_z2kfYtdiEeibyvRfU9vJ7w")]
    [DisplayName("Type")]
    public record Type : TargetMarket3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investor.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required InvestorType2Code Value { get; init; }
    }
}
