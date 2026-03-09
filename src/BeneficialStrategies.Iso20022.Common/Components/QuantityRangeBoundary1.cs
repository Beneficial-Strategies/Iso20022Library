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
/// Limit for a quantity range.
/// </summary>
[IsoId("_jtRfFe5NEeCisYr99QEiWA_-1438940377")]
[DisplayName("Quantity Range Boundary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityRangeBoundary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QuantityRangeBoundary1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QuantityRangeBoundary1( System.UInt64 reqBoundary,System.String reqIncluded )
    {
        Boundary = reqBoundary;
        Included = reqIncluded;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity value of the range limit.
    /// </summary>
    [IsoId("_jtapAO5NEeCisYr99QEiWA_-330775982")]
    [DisplayName("Boundary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bdry")]
    #endif
    [IsoXmlTag("Bdry")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber Boundary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Boundary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Boundary { get; init; } 
    #else
    public System.UInt64 Boundary { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the boundary quantity is included in the range of quantity values.
    /// </summary>
    [IsoId("_jtapAe5NEeCisYr99QEiWA_279625946")]
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
