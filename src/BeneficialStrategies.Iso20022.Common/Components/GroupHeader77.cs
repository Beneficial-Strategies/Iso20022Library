// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the message.
/// </summary>
[IsoId("_CFttTW49EeiU9cctagi5ow")]
[DisplayName("Group Header")]
public partial record GroupHeader77
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the account owner or the party authorised to send the message, and sent to the account servicing institution, to unambiguously identify the message.|Usage: The sender has to make sure that &apos;MessageIdentification&apos; is unique per account servicing institution for a pre-agreed period.
    /// </summary>
    [IsoId("_CQv4gW49EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_CQv4g249EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the party that is sending the message, when different from the account owner.
    /// </summary>
    [IsoId("_CQv4hW49EeiU9cctagi5ow")]
    [DisplayName("Message Sender")]
    [IsoXmlTag("MsgSndr")]
    public Party40Choice_? MessageSender { get; init; } 
    
    
    #nullable disable
    
}
