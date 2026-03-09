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
/// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
/// </summary>
[IsoId("_BRKdmyp8EeyR9JrVGfaMKw")]
[DisplayName("Closing Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClosingBalance5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClosingBalance5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClosingBalance5( ShortLong1Code reqShortLongIndicator,ClosingBalance6Choice_ reqClosingBalance )
    {
        ShortLongIndicator = reqShortLongIndicator;
        ClosingBalance = reqClosingBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_BpAVYyp8EeyR9JrVGfaMKw")]
    [DisplayName("Short Long Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtLngInd")]
    #endif
    [IsoXmlTag("ShrtLngInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code ShortLongIndicator { get; init; } 
    #else
    public ShortLong1Code ShortLongIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    [IsoId("_BpAVayp8EeyR9JrVGfaMKw")]
    [DisplayName("Closing Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgBal")]
    #endif
    [IsoXmlTag("ClsgBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClosingBalance6Choice_ ClosingBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClosingBalance6Choice_ ClosingBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingBalance6Choice_ ClosingBalance { get; init; } 
    #else
    public ClosingBalance6Choice_ ClosingBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
