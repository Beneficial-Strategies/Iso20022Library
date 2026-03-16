// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument27Choice
{
    /// <summary>
    /// Cash Account Details.
    /// </summary>
    [DisplayName("Cash Account Details")]
    public record CashAccountDetails : PaymentInstrument27Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CshAcctDtls")]
        public required InvestmentAccount60 Value { get; init; }
    }
}
