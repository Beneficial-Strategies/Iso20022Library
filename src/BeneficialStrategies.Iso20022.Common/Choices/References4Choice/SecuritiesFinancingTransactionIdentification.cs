// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References4Choice
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing transaction (not the underlying securities financing trade) as assigned by the instructing party.
    /// </summary>
    [IsoId("_UR6fLdp-Ed-ak6NoX_4Aeg_664442061")]
    [DisplayName("Securities Financing Transaction Identification")]
    public record SecuritiesFinancingTransactionIdentification : References4Choice_
    {
        /// <summary>
        /// Provides unambiguous transaction identification information.
        /// </summary>
        [IsoId("_Ui6Ihtp-Ed-ak6NoX_4Aeg_-1040201391")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text TransactionIdentification { get; init; }

        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_Ui6Ih9p-Ed-ak6NoX_4Aeg_-2037273744")]
        [DisplayName("Securities Movement Type")]
        [IsoXmlTag("SctiesMvmntTp")]
        public ReceiveDelivery1Code? SecuritiesMovementType { get; init; }

        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_Ui6IiNp-Ed-ak6NoX_4Aeg_1552578937")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public DeliveryReceiptType2Code? Payment { get; init; }
    }
}
