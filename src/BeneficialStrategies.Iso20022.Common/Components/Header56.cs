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
[IsoId("_E0yzQQt-EeqYM5yH99IYQw")]
[DisplayName("Header")]
public record Header56
{
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    [IsoId("_FBgZkQt-EeqYM5yH99IYQw")]
    [DisplayName("Download Transfer")]
    [IsoXmlTag("DwnldTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; }

    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_FBgZkwt-EeqYM5yH99IYQw")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text FormatVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_FBgZlQt-EeqYM5yH99IYQw")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_FBgZlwt-EeqYM5yH99IYQw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_FBgZmQt-EeqYM5yH99IYQw")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification176 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_FBgZmwt-EeqYM5yH99IYQw")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification177? RecipientParty { get; init; }
}
