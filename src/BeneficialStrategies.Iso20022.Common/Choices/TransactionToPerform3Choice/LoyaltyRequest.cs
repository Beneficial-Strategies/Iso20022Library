// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform3Choice
{
    /// <summary>
    /// Content of the Loyalty Request message.
    /// </summary>
    [IsoId("_xaZiUy8QEeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public record LoyaltyRequest : TransactionToPerform3Choice_
    {
        /// <summary>
        /// To retrieve Card Acquisition Data.
        /// </summary>
        [IsoId("_u0BrQS83Eeu125Ip9zFcsQ")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }

        /// <summary>
        /// Data related to the loyalty transaction.
        /// </summary>
        [IsoId("_u0BrQy83Eeu125Ip9zFcsQ")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required LoyaltyTransaction3 Transaction { get; init; }

        /// <summary>
        /// Data related to a Loyalty program or account.
        /// </summary>
        [IsoId("_u0BrRS83Eeu125Ip9zFcsQ")]
        [DisplayName("Data")]
        [IsoXmlTag("Data")]
        public LoyaltyRequestData2? Data { get; init; }
    }
}
