// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature9Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_iAf0Qz7KEeq0cMLnAmm7Lg")]
    [DisplayName("Non Financial Institution")]
    public record NonFinancialInstitution : CounterpartyTradeNature9Choice_
    {
        /// <summary>
        /// Indicates that reporting party is a central counterparty.
        /// </summary>
        [IsoXmlTag("NFI")]
        public required NoReasonCode Value { get; init; }

        /// <summary>
        /// Identifies the non-financial institution.
        /// </summary>
        [IsoId("_VWgswAbWEeqrW7Meu5r3kQ")]
        [DisplayName("Non Financial Institution Identifier")]
        [IsoXmlTag("NFIIdr")]
        public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; init; }
    }
}
