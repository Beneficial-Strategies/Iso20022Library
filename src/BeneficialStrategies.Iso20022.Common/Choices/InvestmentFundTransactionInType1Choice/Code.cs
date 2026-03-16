// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentFundTransactionInType1Choice
{
    /// <summary>
    /// Transaction type expressed as a code.
    /// </summary>
    [IsoId("_XLrt0AaxEeS3lpTattq7hg")]
    [DisplayName("Code")]
    public record Code : InvestmentFundTransactionInType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investment fund transaction that results in a cash movement into a fund.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundTransactionInType1Code Value { get; init; }
    }
}
