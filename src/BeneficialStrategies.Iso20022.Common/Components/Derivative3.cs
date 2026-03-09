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
/// Financial instrument where the value of the instrument derives from another financial instrument, benchmark or index.
/// </summary>
[IsoId("_63apwLbkEeaqL_M7XFD7PQ")]
[DisplayName("Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Derivative3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Derivative3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Derivative3( DerivativeClassification1 reqDerivativeClassification )
    {
        DerivativeClassification = reqDerivativeClassification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Hierarchy of classification of a derivative.
    /// </summary>
    [IsoId("_hUAMALcHEeabfchHYoktpA")]
    [DisplayName("Derivative Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivClssfctn")]
    #endif
    [IsoXmlTag("DerivClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DerivativeClassification1 DerivativeClassification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DerivativeClassification1 DerivativeClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeClassification1 DerivativeClassification { get; init; } 
    #else
    public DerivativeClassification1 DerivativeClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Rate(s) that determine(s)) the value of the swap during the lifetime of the trade. Where both rates are fixed this does not need to be reported.
    /// </summary>
    [IsoId("_iQdcUMhiEeadgvwNGwK05w")]
    [DisplayName("Derivative Underlying Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivUndrlygLeg")]
    #endif
    [IsoXmlTag("DerivUndrlygLeg")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<DerivativeUnderlyingLeg1> DerivativeUnderlyingLeg { get; init; } = new ValueList<DerivativeUnderlyingLeg1>(){};
    
    /// <summary>
    /// Option specific attributes.
    /// </summary>
    [IsoId("_a8zBcMhiEeadgvwNGwK05w")]
    [DisplayName("Option Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAttrbts")]
    #endif
    [IsoXmlTag("OptnAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Option14? OptionAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Option14? OptionAttributes { get; init; } 
    #else
    public Option14? OptionAttributes { get; set; } 
    #endif
    
    
    #nullable disable
    
}
