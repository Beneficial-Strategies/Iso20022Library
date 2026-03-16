// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationDataRecord1Choice
{
    /// <summary>
    /// Transaction Status.
    /// </summary>
    [DisplayName("Transaction Status")]
    public record TransactionStatus : InvestigationDataRecord1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TxSts")]
        public required PaymentTransactionStatus1 Value { get; init; }
    }
}
