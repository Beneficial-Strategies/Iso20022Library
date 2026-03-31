// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide further details of the message.
/// </summary>
[IsoId("_P31ggtp-Ed-ak6NoX_4Aeg_-1617619263")]
[DisplayName("Group Header")]
public record GroupHeader42
{
    /// <summary>
    /// Point to point reference, as assigned by the account servicing institution, and sent to the account owner or the party authorised to receive the message, to unambiguously identify the message.|Usage: The account servicing institution has to make sure that MessageIdentification is unique per account owner for a pre-agreed period.
    /// </summary>
    [IsoId("_P31gg9p-Ed-ak6NoX_4Aeg_-1617619254")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_P31ghNp-Ed-ak6NoX_4Aeg_-1617618923")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party authorised by the account owner to receive information about movements on the account.|Usage: MessageRecipient should only be identified when different from the account owner.
    /// </summary>
    [IsoId("_P31ghdp-Ed-ak6NoX_4Aeg_-1617618769")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification32? MessageRecipient { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the page number of the message.||Usage: The pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_P31ghtp-Ed-ak6NoX_4Aeg_-1617618829")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination? MessagePagination { get; init; }

    /// <summary>
    /// Further details of the message.
    /// </summary>
    [IsoId("_P31gh9p-Ed-ak6NoX_4Aeg_-1617618954")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }
}
