// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the reject of a transaction.
/// </summary>
[IsoId("_IJl-sY4BEeWrZqsymMFdfg")]
[DisplayName("Header")]
public record Header28
{
    /// <summary>
    /// Indicates if the file transfer is a download or an upload.
    /// </summary>
    [IsoId("_IVN_4Y4BEeWrZqsymMFdfg")]
    [DisplayName("Download Transfer")]
    [IsoXmlTag("DwnldTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DownloadTransfer { get; init; }

    /// <summary>
    /// Version of file format.
    /// </summary>
    [IsoId("_IVN_444BEeWrZqsymMFdfg")]
    [DisplayName("Format Version")]
    [IsoXmlTag("FrmtVrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public required IsoMax6Text FormatVersion { get; init; }

    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [IsoId("_IVN_5Y4BEeWrZqsymMFdfg")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ExchangeIdentification { get; init; }

    /// <summary>
    /// Date and time at which the file or message was created.
    /// </summary>
    [IsoId("_IVN_544BEeWrZqsymMFdfg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_IVN_6Y4BEeWrZqsymMFdfg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public GenericIdentification71? InitiatingParty { get; init; }

    /// <summary>
    /// Unique identification of the partner that is the recipient of the exchange.
    /// </summary>
    [IsoId("_IVN_644BEeWrZqsymMFdfg")]
    [DisplayName("Recipient Party")]
    [IsoXmlTag("RcptPty")]
    public GenericIdentification92? RecipientParty { get; init; }
}
