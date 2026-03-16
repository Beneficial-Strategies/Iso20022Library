// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType6Choice
{
    /// <summary>
    /// Balance type expressed in coded form.
    /// </summary>
    [IsoId("_nArEUvNBEeCuA5Tr22BnwA_-353374082")]
    [DisplayName("Code")]
    public record Code : BalanceType6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the kind of the balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType13Code Value { get; init; }
    }
}
