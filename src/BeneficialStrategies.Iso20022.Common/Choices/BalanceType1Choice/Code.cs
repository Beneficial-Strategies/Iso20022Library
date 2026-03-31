// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType1Choice
{
    /// <summary>
    /// Specifies the code for the type of a balance, eg, opening booked balance.
    /// </summary>
    [IsoId("_RcH9xtp-Ed-ak6NoX_4Aeg_-106550504")]
    [DisplayName("Code")]
    public record Code : BalanceType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the balance, eg, opening balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required BalanceType8Code Value { get; init; }
    }
}
