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
/// Information about a payment against a purchase order.
/// </summary>
[IsoId("_ToDCydp-Ed-ak6NoX_4Aeg_-314950341")]
[DisplayName("Report Line")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportLine1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReportLine1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReportLine1( System.String reqTransactionIdentification,TransactionStatus4 reqTransactionStatus,DocumentIdentification7 reqPurchaseOrderReference,CurrencyAndAmount reqPurchaseOrderTotalNetAmount,CurrencyAndAmount reqAccumulatedNetAmount )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        PurchaseOrderReference = reqPurchaseOrderReference;
        PurchaseOrderTotalNetAmount = reqPurchaseOrderTotalNetAmount;
        AccumulatedNetAmount = reqAccumulatedNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.
    /// </summary>
    [IsoId("_ToMMsNp-Ed-ak6NoX_4Aeg_-80376411")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction.
    /// </summary>
    [IsoId("_ToMMsdp-Ed-ak6NoX_4Aeg_-1126725260")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 TransactionStatus { get; init; } 
    #else
    public TransactionStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the purchase order, assigned by the buyer.
    /// </summary>
    [IsoId("_ToMMstp-Ed-ak6NoX_4Aeg_-43433619")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the purchase order after taxes, adjustments and charges.
    /// </summary>
    [IsoId("_ToMMs9p-Ed-ak6NoX_4Aeg_203143575")]
    [DisplayName("Purchase Order Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrTtlNetAmt")]
    #endif
    [IsoXmlTag("PurchsOrdrTtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount PurchaseOrderTotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount PurchaseOrderTotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount PurchaseOrderTotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount PurchaseOrderTotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Accumulated net amount, after adjustments, intended to be paid.
    /// </summary>
    [IsoId("_ToMMtNp-Ed-ak6NoX_4Aeg_289031555")]
    [DisplayName("Accumulated Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltdNetAmt")]
    #endif
    [IsoXmlTag("AcmltdNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount AccumulatedNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount AccumulatedNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount AccumulatedNetAmount { get; init; } 
    #else
    public CurrencyAndAmount AccumulatedNetAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
