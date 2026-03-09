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
/// Limit for a percentage rate range.
/// </summary>
[IsoId("_8Gekh6MgEeCJ6YNENx4h-w_1560024598")]
[DisplayName("Percentage Range Boundary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PercentageRangeBoundary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PercentageRangeBoundary1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PercentageRangeBoundary1( System.Decimal reqBoundaryRate,System.String reqIncluded )
    {
        BoundaryRate = reqBoundaryRate;
        Included = reqIncluded;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Percentage rate of the range limit.
    /// </summary>
    [IsoId("_8GekiKMgEeCJ6YNENx4h-w_1727044493")]
    [DisplayName("Boundary Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BdryRate")]
    #endif
    [IsoXmlTag("BdryRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate BoundaryRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal BoundaryRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal BoundaryRate { get; init; } 
    #else
    public System.Decimal BoundaryRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the boundary percentage rate is included in the range of percentage rates.
    /// </summary>
    [IsoId("_8GekiaMgEeCJ6YNENx4h-w_-1807157650")]
    [DisplayName("Included")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incl")]
    #endif
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Included { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Included { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Included { get; init; } 
    #else
    public System.String Included { get; set; } 
    #endif
    
    
    #nullable disable
    
}
