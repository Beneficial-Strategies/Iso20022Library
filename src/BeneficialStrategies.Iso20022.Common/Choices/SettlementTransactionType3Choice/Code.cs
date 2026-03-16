// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionType3Choice
{
    /// <summary>
    /// Securities transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_vo7r8ZCAEeakHoV5BVecAQ")]
    [DisplayName("Code")]
    public record Code : SettlementTransactionType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of settlement transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementTransactionType7Code Value { get; init; }
    }
}
