// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group Header116.
/// </summary>
[IsoId("_0xuUsTEyEe6g-ffJsqGiSA")]
[DisplayName("Group Header116")]
public record GroupHeader116
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax500Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Message Pagination.
    /// </summary>
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }

    /// <summary>
    /// Message Recipient.
    /// </summary>
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification272? MessageRecipient { get; init; }

    /// <summary>
    /// Original Business Query.
    /// </summary>
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; }
}
