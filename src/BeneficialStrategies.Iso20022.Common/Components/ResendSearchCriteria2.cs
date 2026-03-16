// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the message(s) which should be resent.
/// </summary>
[IsoId("_Q6TwEZb7Eee4htziCyV8eA")]
[DisplayName("Resend Search Criteria")]
public record ResendSearchCriteria2
{
    /// <summary>
    /// Date of the business day of the requested messages the resend function is used for.
    /// </summary>
    [IsoId("_RDPCkZb7Eee4htziCyV8eA")]
    [DisplayName("Business Date")]
    [IsoXmlTag("BizDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BusinessDate { get; init; }

    /// <summary>
    /// Independent counter for message sequence, which is available once per party technical address.|Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_RDPCk5b7Eee4htziCyV8eA")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; }

    /// <summary>
    /// Independent counter for a range of message sequences, which are available once per party technical address.
    /// Specifies the range of identification sequence numbers for a specific couple sender/receiver.
    /// </summary>
    [IsoId("_UsXFYJb7Eee4htziCyV8eA")]
    [DisplayName("Sequence Range")]
    [IsoXmlTag("SeqRg")]
    public SequenceRange1Choice_? SequenceRange { get; init; }

    /// <summary>
    /// Unambiguously identifies the original bsiness message, which was delivered by the business sender.
    /// </summary>
    [IsoId("_RDPClZb7Eee4htziCyV8eA")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalMessageNameIdentification { get; init; }

    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    [IsoId("_RDPCl5b7Eee4htziCyV8eA")]
    [DisplayName("File Reference")]
    [IsoXmlTag("FileRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FileReference { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the recipient of the report message.
    /// </summary>
    [IsoId("_RDPCmZb7Eee4htziCyV8eA")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required PartyIdentification136 Recipient { get; init; }
}
