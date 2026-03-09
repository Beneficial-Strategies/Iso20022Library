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
/// Strong Customer Authentication exemption details.
/// </summary>
[IsoId("_7zGJkAMgEeujMs2LsB3mMw")]
[DisplayName("Exemption")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Exemption1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Exemption1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Exemption1( Exemption2Code reqType,AttestationValue1Code reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the exemption.
    /// </summary>
    [IsoId("_RTwOoAMhEeujMs2LsB3mMw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Exemption2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Exemption2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Exemption2Code Type { get; init; } 
    #else
    public Exemption2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the exemption.
    /// </summary>
    [IsoId("_XEEAYAMhEeujMs2LsB3mMw")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AttestationValue1Code Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AttestationValue1Code Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttestationValue1Code Value { get; init; } 
    #else
    public AttestationValue1Code Value { get; set; } 
    #endif
    
    /// <summary>
    /// Reason why the exemption claimed was not honored.
    /// </summary>
    [IsoId("_fNKOcAMhEeujMs2LsB3mMw")]
    [DisplayName("Reason Not Honored")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnNotHnrd")]
    #endif
    [IsoXmlTag("RsnNotHnrd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? ReasonNotHonored { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReasonNotHonored { get; init; } 
    #else
    public System.String? ReasonNotHonored { get; set; } 
    #endif
    
    
    #nullable disable
    
}
