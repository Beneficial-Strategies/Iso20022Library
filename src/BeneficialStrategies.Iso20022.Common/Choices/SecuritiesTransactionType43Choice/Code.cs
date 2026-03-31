// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType43Choice
{
    /// <summary>
    /// Securities transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_durwodEfEeiO-eodGv5iKQ")]
    [DisplayName("Code")]
    public record Code : SecuritiesTransactionType43Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of settlement transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType25Code Value { get; init; }
    }
}
