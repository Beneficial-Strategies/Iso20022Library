// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentFundTransactionOutType1Choice
{
    /// <summary>
    /// Transaction type expressed as a code.
    /// </summary>
    [IsoId("_TMto8RMJEeSopak1K45eVQ")]
    [DisplayName("Code")]
    public record Code : InvestmentFundTransactionOutType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investment fund transaction that results in a cash movement out of a fund.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundTransactionOutType1Code Value { get; init; }
    }
}
