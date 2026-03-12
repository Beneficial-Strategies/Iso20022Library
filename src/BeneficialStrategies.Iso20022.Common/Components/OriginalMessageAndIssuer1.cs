// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business reference(s) to one or more relevant messages previously sent by other parties, or by the same party issuing this message.||.
/// </summary>
[IsoId("_76syVKMgEeCJ6YNENx4h-w_830778529")]
[DisplayName("Original Message And Issuer")]
public partial record OriginalMessageAndIssuer1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the original message to which the message refers.
    /// </summary>
    [IsoId("_76syVaMgEeCJ6YNENx4h-w_1092195587")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_762jUKMgEeCJ6YNENx4h-w_-1421660788")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Name of the original party that assigned the original message identification.
    /// </summary>
    [IsoId("_762jUaMgEeCJ6YNENx4h-w_-686714558")]
    [DisplayName("Originator Name")]
    [IsoXmlTag("OrgtrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? OriginatorName { get; init; } 
    
    
    #nullable disable
    
}
