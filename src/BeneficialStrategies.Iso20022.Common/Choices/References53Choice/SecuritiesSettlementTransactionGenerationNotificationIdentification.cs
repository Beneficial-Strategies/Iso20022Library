// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References53Choice
{
    /// <summary>
    /// Unambiguous identification of the notification message to be cancelled.
    /// </summary>
    [IsoId("_6EvMSZNLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Settlement Transaction Generation Notification Identification")]
    public partial record SecuritiesSettlementTransactionGenerationNotificationIdentification : References53Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides unambiguous transaction identification information.
        /// </summary>
        [IsoId("_6EvMU5NLEeWGlc8L7oPDIg")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax16Text TransactionIdentification { get; init; } 
        
        /// <summary>
        /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
        /// </summary>
        [IsoId("_6EvMVZNLEeWGlc8L7oPDIg")]
        [DisplayName("Securities Movement Type")]
        [IsoXmlTag("SctiesMvmntTp")]
        public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
        
        /// <summary>
        /// Specifies how the transaction is to be settled, for example, against payment.
        /// </summary>
        [IsoId("_6EvMV5NLEeWGlc8L7oPDIg")]
        [DisplayName("Payment")]
        [IsoXmlTag("Pmt")]
        public required DeliveryReceiptType2Code Payment { get; init; } 
        
        
        #nullable disable
        
    }
}
