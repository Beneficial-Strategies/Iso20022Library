// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform2Choice
{
    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [IsoId("_ro9DwQxrEeqdx6buGpCCQw")]
    [DisplayName("Payment Request")]
    public record PaymentRequest : TransactionToPerform2Choice_
    {
        /// <summary>
        /// Data associated with the Transaction.
        /// </summary>
        [IsoId("_ioFMMQ1HEeqjM-rxn3HuXQ")]
        [DisplayName("Payment Transaction")]
        [IsoXmlTag("PmtTx")]
        public CardPaymentTransaction100? PaymentTransaction { get; init; }

        /// <summary>
        /// Data linked to card loyalty during payment.
        /// </summary>
        [IsoId("_ioFMMw1HEeqjM-rxn3HuXQ")]
        [DisplayName("Loyalty Data")]
        [IsoXmlTag("LltyData")]
        public LoyaltyRequestData2? LoyaltyData { get; init; }
    }
}
