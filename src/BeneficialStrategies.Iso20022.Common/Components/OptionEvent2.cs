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
/// Events specified in the contract terms of an option.
/// </summary>
[IsoId("_b29F0ZR0Eeeymf3kpbtgrA")]
[DisplayName("Option Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionEvent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionEvent2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionEvent2( OptionEventType1Choice_ reqType,System.String reqDescription )
    {
        Type = reqType;
        Description = reqDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of event in the life of the option.
    /// </summary>
    [IsoId("_cHKsEZR0Eeeymf3kpbtgrA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionEventType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionEventType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionEventType1Choice_ Type { get; init; } 
    #else
    public OptionEventType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the event.
    /// </summary>
    [IsoId("_cHKsE5R0Eeeymf3kpbtgrA")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
