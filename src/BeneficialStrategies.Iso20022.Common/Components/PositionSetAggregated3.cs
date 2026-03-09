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
/// Type of position sets calculated to represent the exposures between a pair of counterparties.
/// </summary>
[IsoId("_0wETAQ1MEeqV4s5SpzR1dQ")]
[DisplayName("Position Set Aggregated")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetAggregated3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PositionSetAggregated3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PositionSetAggregated3( System.DateOnly reqReferenceDate )
    {
        ReferenceDate = reqReferenceDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    [IsoId("_0w29MQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefDt")]
    #endif
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReferenceDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReferenceDate { get; init; } 
    #else
    public System.DateOnly ReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of outstanding derivatives with similar dimensions. Numerous positions sets that are produced according to the combination of dimensions used to stratify the derivatives, and different metrics are used to represent the aggregations. 
    /// </summary>
    [IsoId("_0w29Mw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Position Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosSet")]
    #endif
    [IsoXmlTag("PosSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet5? PositionSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet5? PositionSet { get; init; } 
    #else
    public PositionSet5? PositionSet { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of outstanding derivatives according to the currency of the position, for use by central banks issuing specific currencies.
    /// </summary>
    [IsoId("_0w29NQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Currency Position Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyPosSet")]
    #endif
    [IsoXmlTag("CcyPosSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet5? CurrencyPositionSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet5? CurrencyPositionSet { get; init; } 
    #else
    public PositionSet5? CurrencyPositionSet { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of collateral for derivative positions using collateral fields as metrics.
    /// </summary>
    [IsoId("_0w29Nw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Collateral Position Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPosSet")]
    #endif
    [IsoXmlTag("CollPosSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet4? CollateralPositionSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet4? CollateralPositionSet { get; init; } 
    #else
    public PositionSet4? CollateralPositionSet { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of collateral with similar dimensions that relate to the currency position sets, with relevant collateral related metrics.
    /// </summary>
    [IsoId("_0w29OQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Currency Collateral Position Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyCollPosSet")]
    #endif
    [IsoXmlTag("CcyCollPosSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet4? CurrencyCollateralPositionSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet4? CurrencyCollateralPositionSet { get; init; } 
    #else
    public PositionSet4? CurrencyCollateralPositionSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
