// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Electronic and physical mail address.
/// </summary>
[IsoId("__InD0BrmEeyhRdHRjakS2w")]
[DisplayName("Mail Address")]
public partial record MailAddress1
{
    #nullable enable
    
    /// <summary>
    /// Physical mail address for correspondance.
    /// </summary>
    [IsoId("_j1WRgBrnEeyhRdHRjakS2w")]
    [DisplayName("Correspondence")]
    [IsoXmlTag("Crspdc")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<PostalAddress1> Correspondence { get; init; } = new ValueList<PostalAddress1>(){};
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_vo1tsRrnEeyhRdHRjakS2w")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> EmailAddress { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
