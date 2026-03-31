// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice21Choice
{
    /// <summary>
    /// Nominal Value.
    /// </summary>
    [DisplayName("Nominal Value")]
    public record NominalValue : SecuritiesTransactionPrice21Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("NmnlVal")]
        public required ActiveOrHistoricCurrencyAndAmount Value { get; init; }
    }
}
