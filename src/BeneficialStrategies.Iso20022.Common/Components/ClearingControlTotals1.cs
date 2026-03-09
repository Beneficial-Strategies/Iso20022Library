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
/// Gross clearing control totals.
/// </summary>
[IsoId("_7vrLEFA9EeedyPuM0kK2EQ")]
[DisplayName("Clearing Control Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingControlTotals1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingControlTotals1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingControlTotals1( System.UInt64 reqClearingControlCount,Amount14 reqClearingControlAmount )
    {
        ClearingControlCount = reqClearingControlCount;
        ClearingControlAmount = reqClearingControlAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of clearing transactions. To be used for control purpose.
    /// </summary>
    [IsoId("_MMGhQFA-EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Control Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCtrlCnt")]
    #endif
    [IsoXmlTag("ClrCtrlCnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ClearingControlCount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ClearingControlCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ClearingControlCount { get; init; } 
    #else
    public System.UInt64 ClearingControlCount { get; set; } 
    #endif
    
    /// <summary>
    /// Gross accumulated amount of clearing. To be used for control purpose.
    /// </summary>
    [IsoId("_VGpaYFA-EeedyPuM0kK2EQ")]
    [DisplayName("Clearing Control Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCtrlAmt")]
    #endif
    [IsoXmlTag("ClrCtrlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount14 ClearingControlAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount14 ClearingControlAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14 ClearingControlAmount { get; init; } 
    #else
    public Amount14 ClearingControlAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
