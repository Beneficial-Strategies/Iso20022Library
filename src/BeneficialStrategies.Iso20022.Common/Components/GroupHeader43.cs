// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details on the message.
/// </summary>
[IsoId("_P9WSoNp-Ed-ak6NoX_4Aeg_1664465107")]
[DisplayName("Group Header")]
public partial record GroupHeader43
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the account owner or the party authorised to send the message, and sent to the account servicing institution, to unambiguously identify the message.|Usage: The sender has to make sure that &apos;MessageIdentification&apos; is unique per account servicing institution for a pre-agreed period.
    /// </summary>
    [IsoId("_P9WSodp-Ed-ak6NoX_4Aeg_1664465109")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_P9WSotp-Ed-ak6NoX_4Aeg_1664465478")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the party that is sending the message, when different from the account owner.
    /// </summary>
    [IsoId("_P9WSo9p-Ed-ak6NoX_4Aeg_26964695")]
    [DisplayName("Message Sender")]
    [IsoXmlTag("MsgSndr")]
    public Party7Choice_? MessageSender { get; init; } 
    
    
    #nullable disable
    
}
