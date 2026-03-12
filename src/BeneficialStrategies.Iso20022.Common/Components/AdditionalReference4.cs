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
[IsoId("_Rh7q0dp-Ed-ak6NoX_4Aeg_2077188998")]
[DisplayName("Additional Reference")]
public partial record AdditionalReference4
{
    #nullable enable
    
    /// <summary>
    /// Message identification of a message. This reference was assigned by the party issuing the message.
    /// </summary>
    [IsoId("_Rh7q0tp-Ed-ak6NoX_4Aeg_2077189029")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_Rh7q09p-Ed-ak6NoX_4Aeg_2077189090")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification2Choice_? ReferenceIssuer { get; init; } 
    
    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_Rh7q1Np-Ed-ak6NoX_4Aeg_2077189121")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; } 
    
    
    #nullable disable
    
}
