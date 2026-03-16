// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References37Choice
{
    /// <summary>
    /// Unambiguous identification of the allegement notification to be cancelled as know by the account servicer.
    /// </summary>
    [IsoId("_ts-sRQ34EeKN_Y-2Awiamw")]
    [DisplayName(
        "Securities Settlement Transaction Allegement Notification Transaction Identification"
    )]
    [IsoXmlTag("SctiesSttlmTxAllgmtNtfctnTxId")]
    public record SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification
        : References37Choice_
    {
        /// <summary>
        /// Provides unambiguous transaction identification information.
        /// </summary>
        [IsoId("_H4smFU-2EeCKyoyCaiI0rw")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text TransactionIdentification { get; init; }

        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_H4smH0-2EeCKyoyCaiI0rw")]
        [DisplayName("Securities Movement Type")]
        [IsoXmlTag("SctiesMvmntTp")]
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_H4smKU-2EeCKyoyCaiI0rw")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public required DeliveryReceiptType2Code Payment { get; init; }
    }
}
