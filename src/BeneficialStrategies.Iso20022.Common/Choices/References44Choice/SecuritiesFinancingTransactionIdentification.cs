// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References44Choice
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing transaction (not the underlying securities financing trade) as assigned by the instructing party.
    /// </summary>
    [IsoId("_IIcatTqoEeWyoP0PbocV1Q")]
    [DisplayName("Securities Financing Transaction Identification")]
    [IsoXmlTag("SctiesFincgTxId")]
    public record SecuritiesFinancingTransactionIdentification : References44Choice_
    {
        /// <summary>
        /// Provides unambiguous transaction identification information.
        /// </summary>
        [IsoId("_HIvRMzqoEeWyoP0PbocV1Q")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text TransactionIdentification { get; init; }

        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_HIvRNTqoEeWyoP0PbocV1Q")]
        [DisplayName("Securities Movement Type")]
        [IsoXmlTag("SctiesMvmntTp")]
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_HIvRNzqoEeWyoP0PbocV1Q")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public required DeliveryReceiptType2Code Payment { get; init; }
    }
}
