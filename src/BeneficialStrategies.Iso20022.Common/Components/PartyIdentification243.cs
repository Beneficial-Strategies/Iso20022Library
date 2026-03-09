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
/// Identification of a party.
/// </summary>
[IsoId("_JmJYYygxEeuqgbMAZaNiGw")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification243
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Legal entity.
    /// </summary>
    [IsoId("_JmJYZCgxEeuqgbMAZaNiGw")]
    [DisplayName("Legal Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglPrsn")]
    #endif
    [IsoXmlTag("LglPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification237? LegalPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification237? LegalPerson { get; init; } 
    #else
    public PartyIdentification237? LegalPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Private person.
    /// </summary>
    [IsoId("_JmJYZSgxEeuqgbMAZaNiGw")]
    [DisplayName("Natural Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtrlPrsn")]
    #endif
    [IsoXmlTag("NtrlPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification217? NaturalPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification217? NaturalPerson { get; init; } 
    #else
    public PartyIdentification217? NaturalPerson { get; set; } 
    #endif
    
    
    #nullable disable
    
}
