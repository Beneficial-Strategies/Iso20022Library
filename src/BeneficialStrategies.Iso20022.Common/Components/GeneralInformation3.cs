// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General Information, indicating the function of the message.
/// </summary>
[IsoId("_Su5UBAEcEeCQm6a_G2yO_w_-1968950823")]
[DisplayName("General Information")]
public partial record GeneralInformation3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the message, as assigned by the sender.
    /// </summary>
    [IsoId("_Su5UBQEcEeCQm6a_G2yO_w_-1613875024")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the message is sent as a request or as a response.
    /// </summary>
    [IsoId("_Su5UBgEcEeCQm6a_G2yO_w_-49509778")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public required MessageFunction2Code MessageFunction { get; init; } 
    
    /// <summary>
    /// Reference to the request message for which the notification is sent.
    /// </summary>
    [IsoId("_Su5UBwEcEeCQm6a_G2yO_w_28051799")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RequestReference { get; init; } 
    
    
    #nullable disable
    
}
