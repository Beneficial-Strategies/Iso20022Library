// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification8Choice
{
    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    public record TransactionIdentification : PaymentIdentification8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TxId")]
        public required IsoMax35Text Value { get; init; }
    }
}
