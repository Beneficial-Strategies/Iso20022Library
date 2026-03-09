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
/// Clearing totals of the batch file.
/// </summary>
[IsoId("_vMomEZMwEeuleeHpFMMhmQ")]
[DisplayName("Clearing Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingTotals2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingTotals2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingTotals2( System.UInt64 reqCount,Amount17 reqAccumulatedAmount )
    {
        Count = reqCount;
        AccumulatedAmount = reqAccumulatedAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of transactions to clear.
    /// </summary>
    [IsoId("_vRLu4ZMwEeuleeHpFMMhmQ")]
    [DisplayName("Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnt")]
    #endif
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Count { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Count { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Count { get; init; } 
    #else
    public System.UInt64 Count { get; set; } 
    #endif
    
    /// <summary>
    /// Gross clearing accumulated amount.
    /// </summary>
    [IsoId("_vRLu45MwEeuleeHpFMMhmQ")]
    [DisplayName("Accumulated Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcmltdAmt")]
    #endif
    [IsoXmlTag("AcmltdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount17 AccumulatedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount17 AccumulatedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount17 AccumulatedAmount { get; init; } 
    #else
    public Amount17 AccumulatedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
