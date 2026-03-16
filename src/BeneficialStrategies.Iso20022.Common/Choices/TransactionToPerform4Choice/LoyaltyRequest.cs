// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform4Choice
{
    /// <summary>
    /// Content of the Loyalty Request message.
    /// </summary>
    [IsoId("_8yJLQ031Eey_VecAUE-C9Q")]
    [DisplayName("Loyalty Request")]
    public record LoyaltyRequest : TransactionToPerform4Choice_
    {
        /// <summary>
        /// To retrieve Card Acquisition Data.
        /// </summary>
        [IsoId("_0hjDgU30Eey_VecAUE-C9Q")]
        [DisplayName("Customer Order")]
        [IsoXmlTag("CstmrOrdr")]
        public CustomerOrder1? CustomerOrder { get; init; }

        /// <summary>
        /// Data related to the loyalty transaction.
        /// </summary>
        [IsoId("_0hjDg030Eey_VecAUE-C9Q")]
        [DisplayName("Transaction")]
        [IsoXmlTag("Tx")]
        public required LoyaltyTransaction4 Transaction { get; init; }

        /// <summary>
        /// Data related to a Loyalty program or account.
        /// </summary>
        [IsoId("_0hjDhU30Eey_VecAUE-C9Q")]
        [DisplayName("Data")]
        [IsoXmlTag("Data")]
        public LoyaltyRequestData3? Data { get; init; }
    }
}
