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
[IsoId("_Q6vvAdp-Ed-ak6NoX_4Aeg_2101402955")]
[DisplayName("Additional Reference")]
public partial record AdditionalReference3
{
    #nullable enable
    
    /// <summary>
    /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
    /// </summary>
    [IsoId("_Q6vvAtp-Ed-ak6NoX_4Aeg_2103248321")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_Q6vvA9p-Ed-ak6NoX_4Aeg_2103249887")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification2Choice_? ReferenceIssuer { get; init; } 
    
    /// <summary>
    /// Name of a message.
    /// </summary>
    [IsoId("_Q6vvBNp-Ed-ak6NoX_4Aeg_2103249905")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; } 
    
    
    #nullable disable
    
}
