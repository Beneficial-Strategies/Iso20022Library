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
/// Provides the index used to define the rate and optionally the basis point spread.
/// </summary>
[IsoId("_HhTg5X5aEea2k7EBUopqxw")]
[DisplayName("Floating Interest Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FloatingInterestRate8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FloatingInterestRate8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FloatingInterestRate8( BenchmarkCurveName5Choice_ reqReferenceRate )
    {
        ReferenceRate = reqReferenceRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the reference index for the instrument. 
    /// Usage:
    /// Index or name if the reference rate is not included in the index list.
    /// </summary>
    [IsoId("_Hq0pQX5aEea2k7EBUopqxw")]
    [DisplayName("Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefRate")]
    #endif
    [IsoXmlTag("RefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenchmarkCurveName5Choice_ ReferenceRate { get; init; } 
    #else
    public BenchmarkCurveName5Choice_ ReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Term of the reference rate.
    /// </summary>
    [IsoId("_Hq0pQ35aEea2k7EBUopqxw")]
    [DisplayName("Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Term")]
    #endif
    [IsoXmlTag("Term")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateContractTerm2? Term { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateContractTerm2? Term { get; init; } 
    #else
    public InterestRateContractTerm2? Term { get; set; } 
    #endif
    
    
    #nullable disable
    
}
