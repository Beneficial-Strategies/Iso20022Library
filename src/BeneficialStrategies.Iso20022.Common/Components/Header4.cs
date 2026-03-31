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
[IsoId("_K8wSNn1DEeCF8NjrBemJWQ_469587146")]
[DisplayName("Header")]
public record Header4
{
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    [IsoId("_K8wSN31DEeCF8NjrBemJWQ_355748080")]
    [DisplayName("Download Transfer")]
    [IsoXmlTag("DwnldTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; }

    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_K8wSOH1DEeCF8NjrBemJWQ_-641324273")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text FormatVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_K86DMH1DEeCF8NjrBemJWQ_-1638396626")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public required IsoMax3NumericText ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_K86DMX1DEeCF8NjrBemJWQ_1659498317")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_K86DMn1DEeCF8NjrBemJWQ_-486592385")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification35 InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_K86DM31DEeCF8NjrBemJWQ_-1772185163")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification35? RecipientParty { get; init; }
}
