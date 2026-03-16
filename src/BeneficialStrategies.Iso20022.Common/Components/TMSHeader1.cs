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
[IsoId("_ROuPdwuhEeqw5uEXxQ9H4g")]
[DisplayName("TMS Header")]
public record TMSHeader1
{
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    [IsoId("_ROuPfAuhEeqw5uEXxQ9H4g")]
    [DisplayName("Download Transfer")]
    [IsoXmlTag("DwnldTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; }

    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_ROuPeguhEeqw5uEXxQ9H4g")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text FormatVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_ROuPfQuhEeqw5uEXxQ9H4g")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_ROuPeAuhEeqw5uEXxQ9H4g")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_ROuPewuhEeqw5uEXxQ9H4g")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification176 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_ROuPeQuhEeqw5uEXxQ9H4g")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification177? RecipientParty { get; init; }

    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_2UVvoRBhEeqgJK7e3n_EXA")]
    [DisplayName("Traceability")]
    [IsoXmlTag("Tracblt")]
    public Traceability8? Traceability { get; init; }
}
