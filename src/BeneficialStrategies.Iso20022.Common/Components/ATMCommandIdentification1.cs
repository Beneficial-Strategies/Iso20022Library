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
/// Identification of the entity issuing the command.
/// </summary>
[IsoId("_tbkJAIqKEeSRT5rEzcAHEw")]
[DisplayName("ATM Command Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCommandIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_5ym-MIqKEeSRT5rEzcAHEw")]
    [DisplayName("Origin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgn")]
    #endif
    [IsoXmlTag("Orgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Origin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Origin { get; init; } 
    #else
    public System.String? Origin { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the command for the issuer of the command.
    /// </summary>
    [IsoId("_9G_gEIqKEeSRT5rEzcAHEw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification or address of the host performing the command.
    /// </summary>
    [IsoId("_DAS1wIqLEeSRT5rEzcAHEw")]
    [DisplayName("Processor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prcr")]
    #endif
    [IsoXmlTag("Prcr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Processor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Processor { get; init; } 
    #else
    public System.String? Processor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
