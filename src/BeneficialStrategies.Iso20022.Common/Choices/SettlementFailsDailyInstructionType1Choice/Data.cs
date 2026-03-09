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
namespace BeneficialStrategies.Iso20022.Choices.SettlementFailsDailyInstructionType1Choice
{
    /// <summary>
    /// Aggregated data of settlement instructions.
    /// </summary>
    [IsoId("_em0REzOlEeqX8uoQQ3KffQ")]
    [DisplayName("Data")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Data : SettlementFailsDailyInstructionType1Choice_
    #else
    public partial class Data : SettlementFailsDailyInstructionType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Data instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Data( SettlementDailyFailureReason1Choice_ reqDeliveryVersusPayment,SettlementDailyFailureReason1Choice_ reqDeliveryWithPayment,SettlementDailyFailureReason1Choice_ reqPaymentFreeOfDelivery,SettlementDailyFailureReason1Choice_ reqFreeOfPayment )
        {
            DeliveryVersusPayment = reqDeliveryVersusPayment;
            DeliveryWithPayment = reqDeliveryWithPayment;
            PaymentFreeOfDelivery = reqPaymentFreeOfDelivery;
            FreeOfPayment = reqFreeOfPayment;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Fails due to delivery versus payment (DVP) settlement transactions, covers both delivery versus payment and receive versus payment transactions. 
        /// </summary>
        [IsoId("_MTNhYTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Delivery Versus Payment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvryVrssPmt")]
        #endif
        [IsoXmlTag("DlvryVrssPmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDailyFailureReason1Choice_ DeliveryVersusPayment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDailyFailureReason1Choice_ DeliveryVersusPayment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDailyFailureReason1Choice_ DeliveryVersusPayment { get; init; } 
        #else
        public SettlementDailyFailureReason1Choice_ DeliveryVersusPayment { get; set; } 
        #endif
        
        /// <summary>
        /// Fails due to delivery with payment (DWP) settlement transactions, covers both delivery with payment (DWP) and receive with payment (RWP) transactions. 
        /// </summary>
        [IsoId("_MTNhYzOmEeqX8uoQQ3KffQ")]
        [DisplayName("Delivery With Payment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvryWthPmt")]
        #endif
        [IsoXmlTag("DlvryWthPmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDailyFailureReason1Choice_ DeliveryWithPayment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDailyFailureReason1Choice_ DeliveryWithPayment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDailyFailureReason1Choice_ DeliveryWithPayment { get; init; } 
        #else
        public SettlementDailyFailureReason1Choice_ DeliveryWithPayment { get; set; } 
        #endif
        
        /// <summary>
        /// Fails due to payment free of delivery (PFOD) settlement transactions, covers both debit payment free of delivery (DPFOD) and credit payment free of delivery (CPFOD) transactions.
        /// </summary>
        [IsoId("_MTNhZTOmEeqX8uoQQ3KffQ")]
        [DisplayName("Payment Free Of Delivery")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtFreeOfDlvry")]
        #endif
        [IsoXmlTag("PmtFreeOfDlvry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDailyFailureReason1Choice_ PaymentFreeOfDelivery { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDailyFailureReason1Choice_ PaymentFreeOfDelivery { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDailyFailureReason1Choice_ PaymentFreeOfDelivery { get; init; } 
        #else
        public SettlementDailyFailureReason1Choice_ PaymentFreeOfDelivery { get; set; } 
        #endif
        
        /// <summary>
        /// Fails due to free of payment (FoP) settlement transactions, covers both deliver free of payment (DFoP) and receive free of payment (RFoP) transactions.
        /// </summary>
        [IsoId("_MTNhZzOmEeqX8uoQQ3KffQ")]
        [DisplayName("Free Of Payment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FreeOfPmt")]
        #endif
        [IsoXmlTag("FreeOfPmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SettlementDailyFailureReason1Choice_ FreeOfPayment { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SettlementDailyFailureReason1Choice_ FreeOfPayment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDailyFailureReason1Choice_ FreeOfPayment { get; init; } 
        #else
        public SettlementDailyFailureReason1Choice_ FreeOfPayment { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
