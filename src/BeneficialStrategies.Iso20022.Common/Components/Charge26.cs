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
/// Choice of formats for the type of charge.
/// </summary>
[IsoId("_JVSiqQatEeS3lpTattq7hg")]
[DisplayName("Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charge26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Charge26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Charge26( ChargeType4Choice_ reqType,AmountOrRate3Choice_ reqChargeApplied )
    {
        Type = reqType;
        ChargeApplied = reqChargeApplied;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of charge.
    /// </summary>
    [IsoId("_eget8AatEeS3lpTattq7hg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType4Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType4Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType4Choice_ Type { get; init; } 
    #else
    public ChargeType4Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Charge amount or charge rate applied.
    /// </summary>
    [IsoId("_VRW2gQauEeS3lpTattq7hg")]
    [DisplayName("Charge Applied")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgApld")]
    #endif
    [IsoXmlTag("ChrgApld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrRate3Choice_ ChargeApplied { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrRate3Choice_ ChargeApplied { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrRate3Choice_ ChargeApplied { get; init; } 
    #else
    public AmountOrRate3Choice_ ChargeApplied { get; set; } 
    #endif
    
    
    #nullable disable
    
}
