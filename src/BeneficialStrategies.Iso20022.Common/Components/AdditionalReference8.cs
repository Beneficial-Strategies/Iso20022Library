// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// References a related message or provides another reference, such as a pool reference, linking a set of messages. The party which issued the related reference may be the Sender of the referenced message or a party other than the Sender.
/// </summary>
[IsoId("_udnPoTbsEead9bDRE_1DAQ")]
[DisplayName("Additional Reference")]
public partial record AdditionalReference8
{
    #nullable enable
    
    /// <summary>
    /// Reference issued by a party to identify an instruction, transaction or a message.
    /// </summary>
    [IsoId("_u5IuAzbsEead9bDRE_1DAQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_u5IuBTbsEead9bDRE_1DAQ")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification113? ReferenceIssuer { get; init; } 
    
    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_u5IuBzbsEead9bDRE_1DAQ")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; } 
    
    
    #nullable disable
    
}
