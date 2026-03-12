// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References2Choice
{
    /// <summary>
    /// Unambiguous identification of the securities settlement transaction.
    /// </summary>
    [IsoId("_US9oCtp-Ed-ak6NoX_4Aeg_-95050128")]
    [DisplayName("Securities Settlement Transaction Identification")]
    public partial record SecuritiesSettlementTransactionIdentification : References2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides unambiguous transaction identification information.
        /// </summary>
        [IsoId("_UkGbVdp-Ed-ak6NoX_4Aeg_-140305154")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text TransactionIdentification { get; init; } 
        
        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_UkGbVtp-Ed-ak6NoX_4Aeg_-140305119")]
        [DisplayName("Securities Movement Type")]
        [IsoXmlTag("SctiesMvmntTp")]
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        
        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_UkGbV9p-Ed-ak6NoX_4Aeg_-140305101")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public required DeliveryReceiptType2Code Payment { get; init; } 
        
        
        #nullable disable
        
    }
}
