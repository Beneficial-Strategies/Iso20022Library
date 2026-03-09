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
/// Statistics for a financial instrument generated as part of transparency calculations.
/// </summary>
[IsoId("_D34tONSzEeWG96DaYzntbg")]
[DisplayName("Statistics Transparency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsTransparency2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatisticsTransparency2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatisticsTransparency2( System.UInt64 reqTotalNumberOfTransactionsExecuted,System.UInt64 reqTotalVolumeOfTransactionsExecuted )
    {
        TotalNumberOfTransactionsExecuted = reqTotalNumberOfTransactionsExecuted;
        TotalVolumeOfTransactionsExecuted = reqTotalVolumeOfTransactionsExecuted;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_D35UQ9SzEeWG96DaYzntbg")]
    [DisplayName("Total Number Of Transactions Executed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfTxsExctd")]
    #endif
    [IsoXmlTag("TtlNbOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumberOfTransactionsExecuted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberOfTransactionsExecuted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberOfTransactionsExecuted { get; init; } 
    #else
    public System.UInt64 TotalNumberOfTransactionsExecuted { get; set; } 
    #endif
    
    /// <summary>
    /// Total volume of transactions that have been performed on this market.
    /// </summary>
    [IsoId("_D35URdSzEeWG96DaYzntbg")]
    [DisplayName("Total Volume Of Transactions Executed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlVolOfTxsExctd")]
    #endif
    [IsoXmlTag("TtlVolOfTxsExctd")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber TotalVolumeOfTransactionsExecuted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalVolumeOfTransactionsExecuted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalVolumeOfTransactionsExecuted { get; init; } 
    #else
    public System.UInt64 TotalVolumeOfTransactionsExecuted { get; set; } 
    #endif
    
    
    #nullable disable
    
}
