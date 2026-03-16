// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the transfer of transactions.
/// </summary>
[IsoId("_SzGD4Y3IEeWjkqXgn_0Imw")]
[DisplayName("Header")]
public record Header25
{
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    [IsoId("_S_T68Y3IEeWjkqXgn_0Imw")]
    [DisplayName("Download Transfer")]
    [IsoXmlTag("DwnldTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; }

    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_S_T6843IEeWjkqXgn_0Imw")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text FormatVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_S_T69Y3IEeWjkqXgn_0Imw")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_S_T6943IEeWjkqXgn_0Imw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_S_T6-Y3IEeWjkqXgn_0Imw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification53 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_S_T6-43IEeWjkqXgn_0Imw")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification94? RecipientParty { get; init; }
}
