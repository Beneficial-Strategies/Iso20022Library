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
[IsoId("_s-opElkyEeGeoaLUQk__nA_-409691962")]
[DisplayName("Group Header")]
public partial record GroupHeader60
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the account servicing institution, and sent to the account owner or the party authorised to receive the message, to unambiguously identify the message.||Usage: The account servicing institution has to make sure that &apos;MessageIdentification&apos; is unique per account owner for a pre-agreed period.
    /// </summary>
    [IsoId("_s-opE1kyEeGeoaLUQk__nA_-1019426361")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s-opFFkyEeGeoaLUQk__nA_-492430418")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the party that is receiving the message, when different from the account owner.
    /// </summary>
    [IsoId("_s-xzAFkyEeGeoaLUQk__nA_-366730020")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public Party12Choice_? MessageRecipient { get; init; } 
    
    
    #nullable disable
    
}
