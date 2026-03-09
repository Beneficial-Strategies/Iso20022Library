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
/// Provides the details of a debt instrument in which the periodic interest payments are calculated on the basis of the value (that is, fixing of an underlying reference rate such as the Euribor) on predefined dates (that is, fixing dates) and which has a maturity of no more than one year.
/// </summary>
[IsoId("_GIEfkaifEeWHO_l3hf2rlA")]
[DisplayName("Floating Rate Note")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FloatingRateNote2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FloatingRateNote2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FloatingRateNote2( System.String reqReferenceRateIndex,System.UInt64 reqBasisPointSpread )
    {
        ReferenceRateIndex = reqReferenceRateIndex;
        BasisPointSpread = reqBasisPointSpread;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Underlying reference rate on the basis on which the periodic interest payments are calculated.
    /// </summary>
    [IsoId("_Gm8z8aifEeWHO_l3hf2rlA")]
    [DisplayName("Reference Rate Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefRateIndx")]
    #endif
    [IsoXmlTag("RefRateIndx")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier ReferenceRateIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReferenceRateIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReferenceRateIndex { get; init; } 
    #else
    public System.String ReferenceRateIndex { get; set; } 
    #endif
    
    /// <summary>
    /// Number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    [IsoId("_Gm8z86ifEeWHO_l3hf2rlA")]
    [DisplayName("Basis Point Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisPtSprd")]
    #endif
    [IsoXmlTag("BsisPtSprd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber BasisPointSpread { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 BasisPointSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 BasisPointSpread { get; init; } 
    #else
    public System.UInt64 BasisPointSpread { get; set; } 
    #endif
    
    
    #nullable disable
    
}
