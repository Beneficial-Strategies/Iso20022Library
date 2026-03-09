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
/// Result of performed transactions.
/// </summary>
[IsoId("_b8LzcQxsEeqdx6buGpCCQw")]
[DisplayName("Performed Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PerformedTransaction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PerformedTransaction2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PerformedTransaction2( ResponseType9 reqResponse )
    {
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Response for this performed transaction.
    /// </summary>
    [IsoId("_cHfEgQxsEeqdx6buGpCCQw")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType9 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType9 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType9 Response { get; init; } 
    #else
    public ResponseType9 Response { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of a sale transaction.
    /// </summary>
    [IsoId("_cHfEgwxsEeqdx6buGpCCQw")]
    [DisplayName("Sale Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTxId")]
    #endif
    [IsoXmlTag("SaleTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_cHfEhQxsEeqdx6buGpCCQw")]
    [DisplayName("POI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITxId")]
    #endif
    [IsoXmlTag("POITxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? POITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? POITransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? POITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI reconciliation period.
    /// </summary>
    [IsoId("_cHfEhwxsEeqdx6buGpCCQw")]
    [DisplayName("POI Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIRcncltnId")]
    #endif
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIReconciliationIdentification { get; init; } 
    #else
    public System.String? POIReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_cHfEiQxsEeqdx6buGpCCQw")]
    [DisplayName("Payment Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRslt")]
    #endif
    [IsoXmlTag("PmtRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerPaymentResult2? PaymentResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerPaymentResult2? PaymentResult { get; init; } 
    #else
    public RetailerPaymentResult2? PaymentResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the result of a processed Loyalty transaction.
    /// </summary>
    [IsoId("_cHfEiwxsEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyRslt")]
    #endif
    [IsoXmlTag("LltyRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResult2? LoyaltyResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResult2? LoyaltyResult { get; init; } 
    #else
    public LoyaltyResult2? LoyaltyResult { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the payment or loyalty to reverse.
    /// </summary>
    [IsoId("_cHfEjQxsEeqdx6buGpCCQw")]
    [DisplayName("Reversed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvsdAmt")]
    #endif
    [IsoXmlTag("RvsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ReversedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
