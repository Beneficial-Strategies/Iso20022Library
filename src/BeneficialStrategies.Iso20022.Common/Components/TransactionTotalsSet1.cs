// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of the Sale to POI Reconciliation processing.
/// </summary>
[IsoId("_93n5UNxfEeioifFt1dhnJA")]
[DisplayName("Transaction Totals Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotalsSet1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionTotalsSet1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionTotalsSet1( PaymentInstrumentType1Code reqPaymentInstrumentType,TransactionTotals8 reqTransactionTotal )
    {
        PaymentInstrumentType = reqPaymentInstrumentType;
        TransactionTotal = reqTransactionTotal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of payment instrument.
    /// </summary>
    [IsoId("_KVLmMNxgEeioifFt1dhnJA")]
    [DisplayName("Payment Instrument Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrmTp")]
    #endif
    [IsoXmlTag("PmtInstrmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInstrumentType1Code PaymentInstrumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInstrumentType1Code PaymentInstrumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrumentType1Code PaymentInstrumentType { get; init; } 
    #else
    public PaymentInstrumentType1Code PaymentInstrumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an Acquirer.
    /// </summary>
    [IsoId("_pIKLMNxgEeioifFt1dhnJA")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerIdentification { get; init; } 
    #else
    public System.String? AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a host reconciliation period: acquirer for a payment or server for loyalty.
    /// </summary>
    [IsoId("_0hroMNxgEeioifFt1dhnJA")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationIdentification { get; init; } 
    #else
    public System.String? ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a reconciliation period on the sale system.
    /// </summary>
    [IsoId("__uiiMNxgEeioifFt1dhnJA")]
    [DisplayName("Sale Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRcncltnId")]
    #endif
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReconciliationIdentification { get; init; } 
    #else
    public System.String? SaleReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Brand of payment card or loyalty system.
    /// </summary>
    [IsoId("_DHNuMNxhEeioifFt1dhnJA")]
    [DisplayName("Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnd")]
    #endif
    [IsoXmlTag("Brnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Brand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Brand { get; init; } 
    #else
    public System.String? Brand { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the POI system performing a reconciliation.
    /// </summary>
    [IsoId("_G9gDQNxhEeioifFt1dhnJA")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIIdentification { get; init; } 
    #else
    public System.String? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_KhixwNxhEeioifFt1dhnJA")]
    [DisplayName("Sale Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleId")]
    #endif
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleIdentification { get; init; } 
    #else
    public System.String? SaleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cashier who carried out the transactions.
    /// </summary>
    [IsoId("_Od2PQNxhEeioifFt1dhnJA")]
    [DisplayName("Cashier Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshrId")]
    #endif
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CashierIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashierIdentification { get; init; } 
    #else
    public System.String? CashierIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_RQcSsNxhEeioifFt1dhnJA")]
    [DisplayName("Shift Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShftNb")]
    #endif
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShiftNumber { get; init; } 
    #else
    public System.String? ShiftNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant using the payment services of a payment facilitator, acting as a card acceptor.
    /// </summary>
    [IsoId("_W-gowNxhEeioifFt1dhnJA")]
    [DisplayName("Sponsored Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpnsrdMrchnt")]
    #endif
    [IsoXmlTag("SpnsrdMrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation26? SponsoredMerchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation26? SponsoredMerchant { get; init; } 
    #else
    public Organisation26? SponsoredMerchant { get; set; } 
    #endif
    
    /// <summary>
    /// Payment Transaction totals during the reconciliation period, for a certain type of transaction.
    /// </summary>
    [IsoId("_UIs5QNxhEeioifFt1dhnJA")]
    [DisplayName("Transaction Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtl")]
    #endif
    [IsoXmlTag("TxTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionTotals8 TransactionTotal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionTotals8 TransactionTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals8 TransactionTotal { get; init; } 
    #else
    public TransactionTotals8 TransactionTotal { get; set; } 
    #endif
    
    /// <summary>
    /// Loyalty Transaction totals during the reconciliation period, for a certain type of transaction.
    /// </summary>
    [IsoId("_WAtHQNxiEeioifFt1dhnJA")]
    [DisplayName("Loyalty Transaction Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyTxTtl")]
    #endif
    [IsoXmlTag("LltyTxTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyTransactionTotals1? LoyaltyTransactionTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyTransactionTotals1? LoyaltyTransactionTotal { get; init; } 
    #else
    public LoyaltyTransactionTotals1? LoyaltyTransactionTotal { get; set; } 
    #endif
    
    
    #nullable disable
    
}
