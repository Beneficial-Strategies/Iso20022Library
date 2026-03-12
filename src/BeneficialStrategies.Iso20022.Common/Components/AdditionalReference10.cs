// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference and reference issuer.
/// </summary>
[IsoId("_ZBypsWpTEeipaMTLlhaKMQ")]
[DisplayName("Additional Reference")]
public partial record AdditionalReference10
{
    #nullable enable
    
    /// <summary>
    /// Reference issued by a party to identify an instruction, transaction or a message.
    /// </summary>
    [IsoId("_ZSms42pTEeipaMTLlhaKMQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_ZSms5WpTEeipaMTLlhaKMQ")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification139? ReferenceIssuer { get; init; } 
    
    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_ZSms52pTEeipaMTLlhaKMQ")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; } 
    
    
    #nullable disable
    
}
