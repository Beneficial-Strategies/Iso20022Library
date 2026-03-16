// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform5Choice
{
    /// <summary>
    /// Content of the Loyalty Request message.
    /// </summary>
    [IsoId("_Xt0vE3GwEe2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public record LoyaltyRequest : TransactionToPerform5Choice_
    {
        /// <summary>
        /// To retrieve Card Acquisition Data.
        /// </summary>
        [IsoId("_fE1OUXGvEe2TbaNWBpRZpQ")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }

        /// <summary>
        /// Data related to the loyalty transaction.
        /// </summary>
        [IsoId("_fE1OU3GvEe2TbaNWBpRZpQ")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required LoyaltyTransaction5 Transaction { get; init; }

        /// <summary>
        /// Data related to a Loyalty program or account.
        /// </summary>
        [IsoId("_fE1OVXGvEe2TbaNWBpRZpQ")]
        [DisplayName("Data")]
        [IsoXmlTag("Data")]
        public LoyaltyRequestData3? Data { get; init; }
    }
}
