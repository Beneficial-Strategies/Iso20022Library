// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType8Choice
{
    /// <summary>
    /// Specifies the nature of a balance, in a coded form.
    /// </summary>
    [IsoId("_74nutqMgEeCJ6YNENx4h-w_-1104828389")]
    [DisplayName("Code")]
    public record Code : BalanceType8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the system balance, such as opening balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemBalanceType1Code Value { get; init; }
    }
}
