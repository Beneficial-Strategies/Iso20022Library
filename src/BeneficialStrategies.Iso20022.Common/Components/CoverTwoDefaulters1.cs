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
/// Identifies the two largest assumed defaulting entities under a particular scenario.
/// </summary>
[IsoId("_hs1wsLJPEeaYqc4G3TTwhA")]
[DisplayName("Cover Two Defaulters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CoverTwoDefaulters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CoverTwoDefaulters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CoverTwoDefaulters1( System.String reqCover1Identification,System.String reqCover2Identification )
    {
        Cover1Identification = reqCover1Identification;
        Cover2Identification = reqCover2Identification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the member whose default would generate the largest liquidity exposure for the CCP under the scenario and for the relevant currency.
    /// </summary>
    [IsoId("_mgMyALJPEeaYqc4G3TTwhA")]
    [DisplayName("Cover 1 Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cover1Id")]
    #endif
    [IsoXmlTag("Cover1Id")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier Cover1Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Cover1Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Cover1Identification { get; init; } 
    #else
    public System.String Cover1Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the member whose default would generate the second largest liquidity exposure for the CCP under the scenario and for the relevant currency.
    /// </summary>
    [IsoId("_ox2EgLJPEeaYqc4G3TTwhA")]
    [DisplayName("Cover 2 Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cover2Id")]
    #endif
    [IsoXmlTag("Cover2Id")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier Cover2Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Cover2Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Cover2Identification { get; init; } 
    #else
    public System.String Cover2Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
