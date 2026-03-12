// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing further details on the message.
/// </summary>
[IsoId("_PynpV9p-Ed-ak6NoX_4Aeg_-1593387431")]
[DisplayName("Group Header")]
public partial record GroupHeader23
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the account servicing institution and sent to the account owner to unambiguously identify the message.||Usage: The account servicing institution has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PynpWNp-Ed-ak6NoX_4Aeg_-1476102620")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was created by the account servicer.
    /// </summary>
    [IsoId("_PynpWdp-Ed-ak6NoX_4Aeg_738792555")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Party that is entitled by the account owner to receive information about movements in the account. ||Guideline: MessageRecipient should only be identified when different from the account owner.
    /// </summary>
    [IsoId("_PyxaUNp-Ed-ak6NoX_4Aeg_-877214038")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification8? MessageRecipient { get; init; } 
    
    /// <summary>
    /// Pagination of the message.||Usage: the pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_PyxaUdp-Ed-ak6NoX_4Aeg_-1335279849")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination? MessagePagination { get; init; } 
    
    /// <summary>
    /// Further details on the message.
    /// </summary>
    [IsoId("_PyxaUtp-Ed-ak6NoX_4Aeg_-1476102585")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
