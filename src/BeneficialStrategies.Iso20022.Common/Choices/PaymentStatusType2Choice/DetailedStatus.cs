// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusType2Choice
{
    /// <summary>
    /// Contains the detailed status of the payment.
    /// </summary>
    [IsoId("_C2TSYyYMEei7VPGVFTQkxA")]
    [DisplayName("Detailed Status")]
    public partial record DetailedStatus : PaymentStatusType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identifies the party that issues the status.
        /// </summary>
        [IsoId("_C-RioSYMEei7VPGVFTQkxA")]
        [DisplayName("Originator")]
        [IsoXmlTag("Orgtr")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Originator { get; init; } 
        
        /// <summary>
        /// Date and time at which the funds are available,  as reported in the ACSC status update.
        /// </summary>
        [IsoId("_C-RioyYMEei7VPGVFTQkxA")]
        [DisplayName("Funds Available")]
        [IsoXmlTag("FndsAvlbl")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? FundsAvailable { get; init; } 
        
        /// <summary>
        /// Specifies the status of the transaction.
        /// </summary>
        [IsoId("_C-RipSYMEei7VPGVFTQkxA")]
        [DisplayName("Transaction Status")]
        [IsoXmlTag("TxSts")]
        public required PaymentStatus5 TransactionStatus { get; init; } 
        
        /// <summary>
        /// Identifies the entity to which the entity reporting the status has forwarded the payment transaction.
        /// Usage:
        /// This element can only be used in case the status is ACSP and the reason is G000 or G001.
        /// </summary>
        [IsoId("_C-RipyYMEei7VPGVFTQkxA")]
        [DisplayName("Forwarded To Agent")]
        [IsoXmlTag("FwddToAgt")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public IsoAnyBICIdentifier? ForwardedToAgent { get; init; } 
        
        /// <summary>
        /// Specifies the amount confirmed by the Originator. Depending on the Transaction Status, this amount can be the credited amount, pending amount, rejected amount or transferred amount.
        /// </summary>
        [IsoId("_C-RiqSYMEei7VPGVFTQkxA")]
        [DisplayName("Confirmed Amount")]
        [IsoXmlTag("ConfdAmt")]
        public required ActiveOrHistoricCurrencyAndAmount ConfirmedAmount { get; init; } 
        
        /// <summary>
        /// Specifies the exchange rate details between two currencies.
        /// </summary>
        [IsoId("_C-RiqyYMEei7VPGVFTQkxA")]
        [DisplayName("Foreign Exchange Details")]
        [IsoXmlTag("FXDtls")]
        public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
        
        /// <summary>
        /// Amount of money asked or paid for the charge.
        /// </summary>
        [IsoId("_C-RirSYMEei7VPGVFTQkxA")]
        [DisplayName("Charge Amount")]
        [IsoXmlTag("ChrgAmt")]
        public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
        
        
        #nullable disable
        
    }
}
