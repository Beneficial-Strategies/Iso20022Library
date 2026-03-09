// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusType2Choice
{
    /// <summary>
    /// Contains the detailed status of the payment.
    /// </summary>
    [IsoId("_C2TSYyYMEei7VPGVFTQkxA")]
    [DisplayName("Detailed Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DetailedStatus : PaymentStatusType2Choice_
    #else
    public partial class DetailedStatus : PaymentStatusType2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DetailedStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DetailedStatus( System.String reqOriginator,PaymentStatus5 reqTransactionStatus,ActiveOrHistoricCurrencyAndAmount reqConfirmedAmount )
        {
            Originator = reqOriginator;
            TransactionStatus = reqTransactionStatus;
            ConfirmedAmount = reqConfirmedAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the party that issues the status.
        /// </summary>
        [IsoId("_C-RioSYMEei7VPGVFTQkxA")]
        [DisplayName("Originator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Orgtr")]
        #endif
        [IsoXmlTag("Orgtr")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoAnyBICIdentifier Originator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Originator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Originator { get; init; } 
        #else
        public System.String Originator { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the funds are available,  as reported in the ACSC status update.
        /// </summary>
        [IsoId("_C-RioyYMEei7VPGVFTQkxA")]
        [DisplayName("Funds Available")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FndsAvlbl")]
        #endif
        [IsoXmlTag("FndsAvlbl")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? FundsAvailable { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? FundsAvailable { get; init; } 
        #else
        public System.DateTime? FundsAvailable { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the status of the transaction.
        /// </summary>
        [IsoId("_C-RipSYMEei7VPGVFTQkxA")]
        [DisplayName("Transaction Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxSts")]
        #endif
        [IsoXmlTag("TxSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PaymentStatus5 TransactionStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PaymentStatus5 TransactionStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentStatus5 TransactionStatus { get; init; } 
        #else
        public PaymentStatus5 TransactionStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the entity to which the entity reporting the status has forwarded the payment transaction.
        /// Usage:
        /// This element can only be used in case the status is ACSP and the reason is G000 or G001.
        /// </summary>
        [IsoId("_C-RipyYMEei7VPGVFTQkxA")]
        [DisplayName("Forwarded To Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FwddToAgt")]
        #endif
        [IsoXmlTag("FwddToAgt")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoAnyBICIdentifier? ForwardedToAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ForwardedToAgent { get; init; } 
        #else
        public System.String? ForwardedToAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the amount confirmed by the Originator. Depending on the Transaction Status, this amount can be the credited amount, pending amount, rejected amount or transferred amount.
        /// </summary>
        [IsoId("_C-RiqSYMEei7VPGVFTQkxA")]
        [DisplayName("Confirmed Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ConfdAmt")]
        #endif
        [IsoXmlTag("ConfdAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyAndAmount ConfirmedAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveOrHistoricCurrencyAndAmount ConfirmedAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount ConfirmedAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount ConfirmedAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the exchange rate details between two currencies.
        /// </summary>
        [IsoId("_C-RiqyYMEei7VPGVFTQkxA")]
        [DisplayName("Foreign Exchange Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FXDtls")]
        #endif
        [IsoXmlTag("FXDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
        #else
        public CurrencyExchange12? ForeignExchangeDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money asked or paid for the charge.
        /// </summary>
        [IsoId("_C-RirSYMEei7VPGVFTQkxA")]
        [DisplayName("Charge Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ChrgAmt")]
        #endif
        [IsoXmlTag("ChrgAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
