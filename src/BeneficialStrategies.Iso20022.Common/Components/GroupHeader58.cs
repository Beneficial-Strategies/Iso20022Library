// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the message.
/// </summary>
[IsoId("_s-L9JFkyEeGeoaLUQk__nA_460842520")]
[DisplayName("Group Header")]
public record GroupHeader58
{
    /// <summary>
    /// Point to point reference, as assigned by the account servicing institution, and sent to the account owner or the party authorised to receive the message, to unambiguously identify the message.|Usage: The account servicing institution has to make sure that MessageIdentification is unique per account owner for a pre-agreed period.
    /// </summary>
    [IsoId("_s-L9JVkyEeGeoaLUQk__nA_130898739")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s-VuIFkyEeGeoaLUQk__nA_-445732463")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party authorised by the account owner to receive information about movements on the account.|Usage: MessageRecipient should only be identified when different from the account owner.
    /// </summary>
    [IsoId("_s-VuIVkyEeGeoaLUQk__nA_1676971455")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification43? MessageRecipient { get; init; }

    /// <summary>
    /// Provides details on the page number of the message.||Usage: The pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_s-VuIlkyEeGeoaLUQk__nA_-1500797128")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination? MessagePagination { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the original requestor, to unambiguously identify the business query message.
    /// </summary>
    [IsoId("_s-VuI1kyEeGeoaLUQk__nA_-1782595332")]
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; }

    /// <summary>
    /// Further details of the message.
    /// </summary>
    [IsoId("_s-e4EFkyEeGeoaLUQk__nA_-1429157449")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }
}
