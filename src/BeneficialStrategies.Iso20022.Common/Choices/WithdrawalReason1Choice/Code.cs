// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.WithdrawalReason1Choice
{
    /// <summary>
    /// Withdrawal reason expressed as a code.
    /// </summary>
    [IsoId("_SpFGUE7XEeifNrXGwadPmg")]
    [DisplayName("Code")]
    public record Code : WithdrawalReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a reason for a withdrawal from the investment product.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PortfolioWithdrawalReason1Code Value { get; init; }
    }
}
