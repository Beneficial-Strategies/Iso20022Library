// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType9Choice
{
    /// <summary>
    /// Specifies the nature of a balance, in a coded form.
    /// </summary>
    [IsoId("_77AUUqMgEeCJ6YNENx4h-w_609741360")]
    [DisplayName("Code")]
    public record Code : BalanceType9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the balance within a system processing the transactions.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SystemBalanceType2Code Value { get; init; }
    }
}
