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
/// Specifies aggregated details on transactions within a defined numeric range bin.
/// </summary>
[IsoId("_mbY-AUD5EeW1yage4PQ__A")]
[DisplayName("Transactions Bin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionsBin2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionsBin2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionsBin2( System.UInt64 reqNumberOfTransactions,System.UInt64 reqTotalNotionalAmount,FromToQuantityRange2 reqRange )
    {
        NumberOfTransactions = reqNumberOfTransactions;
        TotalNotionalAmount = reqTotalNotionalAmount;
        Range = reqRange;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of transactions executed for that bin. Transactions that have been cancelled should be excluded from the reported figure.
    /// </summary>
    [IsoId("_mmgB00D5EeW1yage4PQ__A")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfTransactions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfTransactions { get; init; } 
    #else
    public System.UInt64 NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total notional amount traded represented by all transactions executed on the reporting day which size lies in the bin&apos;s range, expressed in the currency as specified in the local regulation (except for emission allowances and emission allowance derivatives: tons of carbon dioxide). Transactions that have been cancelled should be excluded from the reported figure.
    /// </summary>
    [IsoId("_mmgB1UD5EeW1yage4PQ__A")]
    [DisplayName("Total Notional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNtnlAmt")]
    #endif
    [IsoXmlTag("TtlNtnlAmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber TotalNotionalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNotionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNotionalAmount { get; init; } 
    #else
    public System.UInt64 TotalNotionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specific range the quantitative data relates to. Only allowed ranges must be used.
    /// </summary>
    [IsoId("_mmgB10D5EeW1yage4PQ__A")]
    [DisplayName("Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rg")]
    #endif
    [IsoXmlTag("Rg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FromToQuantityRange2 Range { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FromToQuantityRange2 Range { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FromToQuantityRange2 Range { get; init; } 
    #else
    public FromToQuantityRange2 Range { get; set; } 
    #endif
    
    
    #nullable disable
    
}
