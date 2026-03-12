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
[IsoId("_P9gDotp-Ed-ak6NoX_4Aeg_1780446347")]
[DisplayName("Group Header")]
public partial record GroupHeader44
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the account servicing institution, and sent to the account owner or the party authorised to receive the message, to unambiguously identify the message.||Usage: The account servicing institution has to make sure that &apos;MessageIdentification&apos; is unique per account owner for a pre-agreed period.
    /// </summary>
    [IsoId("_P9gDo9p-Ed-ak6NoX_4Aeg_1780446408")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_P9gDpNp-Ed-ak6NoX_4Aeg_1780446500")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the party that is receiving the message, when different from the account owner.
    /// </summary>
    [IsoId("_P9gDpdp-Ed-ak6NoX_4Aeg_1780446841")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public Party7Choice_? MessageRecipient { get; init; } 
    
    
    #nullable disable
    
}
