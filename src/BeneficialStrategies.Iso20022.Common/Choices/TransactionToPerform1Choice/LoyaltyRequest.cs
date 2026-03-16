// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform1Choice
{
    /// <summary>
    /// Content of the Loyalty Request message.
    /// </summary>
    [IsoId("_57p-oNuREeiB5uLfkg9ZJA")]
    [DisplayName("Loyalty Request")]
    [IsoXmlTag("LltyReq")]
    public record LoyaltyRequest : TransactionToPerform1Choice_
    {
        /// <summary>
        /// To retrieve Card Acquisition Data.
        /// </summary>
        [IsoId("_WzxBINuMEeiB5uLfkg9ZJA")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }

        /// <summary>
        /// Data related to the loyalty transaction.
        /// </summary>
        [IsoId("_ZkYuoNuMEeiB5uLfkg9ZJA")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required LoyaltyTransaction1 Transaction { get; init; }

        /// <summary>
        /// Data related to a Loyalty program or account.
        /// </summary>
        [IsoId("_dN7BINuMEeiB5uLfkg9ZJA")]
        [DisplayName("Data")]
        [IsoXmlTag("Data")]
        public LoyaltyRequestData1? Data { get; init; }
    }
}
