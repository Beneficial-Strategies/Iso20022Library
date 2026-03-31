// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType11Choice
{
    /// <summary>
    /// Securities transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_fw8YIfvmEeCBQp5TnX1XKQ")]
    [DisplayName("Code")]
    public record Code : SecuritiesTransactionType11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType9Code Value { get; init; }
    }
}
