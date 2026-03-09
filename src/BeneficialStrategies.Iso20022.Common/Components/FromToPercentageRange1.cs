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
/// Range of percentage rates.
/// </summary>
[IsoId("_7_BRpaMgEeCJ6YNENx4h-w_873727815")]
[DisplayName("From To Percentage Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FromToPercentageRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FromToPercentageRange1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FromToPercentageRange1( PercentageRangeBoundary1 reqFrom,PercentageRangeBoundary1 reqTo )
    {
        From = reqFrom;
        To = reqTo;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of percentage rates.
    /// </summary>
    [IsoId("_7_BRpqMgEeCJ6YNENx4h-w_-455806218")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PercentageRangeBoundary1 From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PercentageRangeBoundary1 From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PercentageRangeBoundary1 From { get; init; } 
    #else
    public PercentageRangeBoundary1 From { get; set; } 
    #endif
    
    /// <summary>
    /// Upper boundary of a range of percentage rates.
    /// </summary>
    [IsoId("_7_BRp6MgEeCJ6YNENx4h-w_898182717")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PercentageRangeBoundary1 To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PercentageRangeBoundary1 To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PercentageRangeBoundary1 To { get; init; } 
    #else
    public PercentageRangeBoundary1 To { get; set; } 
    #endif
    
    
    #nullable disable
    
}
