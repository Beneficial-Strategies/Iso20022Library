// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business reference(s) to one or more relevant messages previously sent by other parties, or by the same party issuing this message.
/// </summary>
[IsoId("_hl9VYZb4Eee4htziCyV8eA")]
[DisplayName("Message Reference")]
public partial record MessageReference1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to a previous message having a business relevance with this message.
    /// </summary>
    [IsoId("_hub785b4Eee4htziCyV8eA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    /// <summary>
    /// Name of the message which contained the given additional reference as its message reference.
    /// </summary>
    [IsoId("_hub79Zb4Eee4htziCyV8eA")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; } 
    
    /// <summary>
    /// Party that initially assigned the given additional reference.
    /// </summary>
    [IsoId("_hub795b4Eee4htziCyV8eA")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification136? ReferenceIssuer { get; init; } 
    
    
    #nullable disable
    
}
