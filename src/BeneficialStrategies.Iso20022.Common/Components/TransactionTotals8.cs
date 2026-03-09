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
[IsoId("_hIiMwdxhEeioifFt1dhnJA")]
[DisplayName("Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotals8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionTotals8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionTotals8( TypeTransactionTotals3Code reqType,System.UInt64 reqTotalNumber,ImpliedCurrencyAndAmount reqCumulativeAmount )
    {
        Type = reqType;
        TotalNumber = reqTotalNumber;
        CumulativeAmount = reqCumulativeAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_hRq6odxhEeioifFt1dhnJA")]
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
    /// Category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_hRq6o9xhEeioifFt1dhnJA")]
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
    [IsoId("_hRq6pdxhEeioifFt1dhnJA")]
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
    /// Identification of the type of transaction.
    /// </summary>
    [IsoId("_hRq6p9xhEeioifFt1dhnJA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeTransactionTotals3Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeTransactionTotals3Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeTransactionTotals3Code Type { get; init; } 
    #else
    public TypeTransactionTotals3Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    [IsoId("_hRq6qdxhEeioifFt1dhnJA")]
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
    [IsoId("_hRq6q9xhEeioifFt1dhnJA")]
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
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_GjQh0NxiEeioifFt1dhnJA")]
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
