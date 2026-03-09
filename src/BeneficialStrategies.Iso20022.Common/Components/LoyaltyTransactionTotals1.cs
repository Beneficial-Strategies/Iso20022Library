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
/// Transaction totals during the reconciliation period, for a certain type of transaction.
/// </summary>
[IsoId("_XpAh0NxiEeioifFt1dhnJA")]
[DisplayName("Loyalty Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyTransactionTotals1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoyaltyTransactionTotals1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoyaltyTransactionTotals1( LoyaltyTypeTransactionTotals1Code reqTransactionType,System.UInt64 reqTotalNumber,ImpliedCurrencyAndAmount reqCumulativeAmount )
    {
        TransactionType = reqTransactionType;
        TotalNumber = reqTotalNumber;
        CumulativeAmount = reqCumulativeAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_gDkTUNxiEeioifFt1dhnJA")]
    [DisplayName("POI Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIGrpId")]
    #endif
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIGroupIdentification { get; init; } 
    #else
    public System.String? POIGroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of the amount, expressed in point or in a monetary value and a currency.
    /// </summary>
    [IsoId("_jRtDQNxiEeioifFt1dhnJA")]
    [DisplayName("Loyalty Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyUnit")]
    #endif
    [IsoXmlTag("LltyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountUnit1Code? LoyaltyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountUnit1Code? LoyaltyUnit { get; init; } 
    #else
    public AmountUnit1Code? LoyaltyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Cards category related to the acceptance processing rules defined by the Loyalty provider.
    /// </summary>
    [IsoId("_nFAVwNxiEeioifFt1dhnJA")]
    [DisplayName("Card Product Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctPrfl")]
    #endif
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductProfile { get; init; } 
    #else
    public System.String? CardProductProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    [IsoId("_qL-GsNxiEeioifFt1dhnJA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Type of Loyalty transaction for Report.
    /// </summary>
    [IsoId("_xggEQNxiEeioifFt1dhnJA")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LoyaltyTypeTransactionTotals1Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LoyaltyTypeTransactionTotals1Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyTypeTransactionTotals1Code TransactionType { get; init; } 
    #else
    public LoyaltyTypeTransactionTotals1Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    [IsoId("_U5AC4NxjEeioifFt1dhnJA")]
    [DisplayName("Total Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNb")]
    #endif
    [IsoXmlTag("TtlNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumber { get; init; } 
    #else
    public System.UInt64 TotalNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of a collection of transactions.
    /// </summary>
    [IsoId("_XOIuQNxjEeioifFt1dhnJA")]
    [DisplayName("Cumulative Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmltvAmt")]
    #endif
    [IsoXmlTag("CmltvAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount CumulativeAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount CumulativeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount CumulativeAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount CumulativeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amounts associated with the total amount of transactions.
    /// </summary>
    [IsoId("_a83CwNxjEeioifFt1dhnJA")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount15? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount15? DetailedAmount { get; init; } 
    #else
    public DetailedAmount15? DetailedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
