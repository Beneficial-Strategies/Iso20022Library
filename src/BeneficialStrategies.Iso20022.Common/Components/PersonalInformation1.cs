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
/// Information related to the identification of a person.
/// </summary>
[IsoId("_KaECoDnlEeW7UoCHqpiMaQ")]
[DisplayName("Personal Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonalInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the father of the individual person.
    /// </summary>
    [IsoId("_ZTjmcDnlEeW7UoCHqpiMaQ")]
    [DisplayName("Name Of Father")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmOfFthr")]
    #endif
    [IsoXmlTag("NmOfFthr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NameOfFather { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameOfFather { get; init; } 
    #else
    public System.String? NameOfFather { get; set; } 
    #endif
    
    /// <summary>
    /// Maiden (unmarried) name of the mother of the individual person.
    /// </summary>
    [IsoId("_ZTjmcTnlEeW7UoCHqpiMaQ")]
    [DisplayName("Maiden Name Of Mother")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdnNmOfMthr")]
    #endif
    [IsoXmlTag("MdnNmOfMthr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MaidenNameOfMother { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaidenNameOfMother { get; init; } 
    #else
    public System.String? MaidenNameOfMother { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the partner of the individual person.
    /// </summary>
    [IsoId("_ZTjmcjnlEeW7UoCHqpiMaQ")]
    [DisplayName("Name Of Partner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmOfPrtnr")]
    #endif
    [IsoXmlTag("NmOfPrtnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NameOfPartner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameOfPartner { get; init; } 
    #else
    public System.String? NameOfPartner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
