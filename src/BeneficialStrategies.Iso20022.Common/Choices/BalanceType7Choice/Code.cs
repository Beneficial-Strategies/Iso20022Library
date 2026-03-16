// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType7Choice
{
    /// <summary>
    /// Balance type expressed in coded form.
    /// </summary>
    [IsoId("_nAhTWPNBEeCuA5Tr22BnwA_218761826")]
    [DisplayName("Code")]
    public record Code : BalanceType7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies balances of assets and other balances.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FinancialAssetBalanceType1Code Value { get; init; }
    }
}
