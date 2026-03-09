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
/// Electronic and physical mail address.
/// </summary>
[IsoId("__InD0BrmEeyhRdHRjakS2w")]
[DisplayName("Mail Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MailAddress1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Physical mail address for correspondance.
    /// </summary>
    [IsoId("_j1WRgBrnEeyhRdHRjakS2w")]
    [DisplayName("Correspondence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crspdc")]
    #endif
    [IsoXmlTag("Crspdc")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Correspondence { get; init; } = new ValueList<PostalAddress1>(){};
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_vo1tsRrnEeyhRdHRjakS2w")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> EmailAddress { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
