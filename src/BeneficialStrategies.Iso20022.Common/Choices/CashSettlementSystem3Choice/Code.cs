// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystem3Choice
{
    /// <summary>
    /// Cash settlement system expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Aav3xdokEeC60axPepSq7g_1625355398")]
    [DisplayName("Code")]
    public record Code : CashSettlementSystem3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the cash settlement system used.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CashSettlementSystem2Code Value { get; init; }
    }
}
