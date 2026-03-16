// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control related document or letter supporting the contract registration.
/// </summary>
[IsoId("_LUGvaW49EeiU9cctagi5ow")]
[DisplayName("Supporting Document Request Or Letter")]
public record SupportingDocumentRequestOrLetter2
{
    /// <summary>
    /// Unique and unambiguous identification of the supporting document request or the letter.
    /// </summary>
    [IsoId("_LdpF4W49EeiU9cctagi5ow")]
    [DisplayName("Request Or Letter Identification")]
    [IsoXmlTag("ReqOrLttrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RequestOrLetterIdentification { get; init; }

    /// <summary>
    /// Date of the supporting document request or the letter.
    /// </summary>
    [IsoId("_LdpF4249EeiU9cctagi5ow")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Sender of the request or letter.
    /// </summary>
    [IsoId("_LdpF5W49EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public Party40Choice_? Sender { get; init; }

    /// <summary>
    /// Receiver of the request or letter.
    /// </summary>
    [IsoId("_LdpF5249EeiU9cctagi5ow")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public Party40Choice_? Receiver { get; init; }

    /// <summary>
    /// Provides the references of the original underlying message(s) for which supporting documents are requested or for which the letter is sent.
    /// </summary>
    [IsoId("_LdpF6W49EeiU9cctagi5ow")]
    [DisplayName("Original References")]
    [IsoXmlTag("OrgnlRefs")]
    public ValueList<OriginalMessage4> OriginalReferences { get; init; } = [];

    /// <summary>
    /// Subject of the letter or supporting document.
    /// </summary>
    [IsoId("_LdpF6249EeiU9cctagi5ow")]
    [DisplayName("Subject")]
    [IsoXmlTag("Sbjt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Subject { get; init; }

    /// <summary>
    /// Provides the type of supporting document requested.
    /// </summary>
    [IsoId("_LdpF7W49EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SupportDocumentType1Code Type { get; init; }

    /// <summary>
    /// Further free format description of the request.
    /// </summary>
    [IsoId("_LdpF7249EeiU9cctagi5ow")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? Description { get; init; }

    /// <summary>
    /// Flag to indicate whether a response is required or not.
    /// Usage: when the request is used to send a letter, there is no response required.
    /// </summary>
    [IsoId("_LdpF8W49EeiU9cctagi5ow")]
    [DisplayName("Response Required")]
    [IsoXmlTag("RspnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ResponseRequired { get; init; }

    /// <summary>
    /// Date by which the response to the request is expected.
    /// </summary>
    [IsoId("_LdpF8249EeiU9cctagi5ow")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Documents provided as attachments to the supporting document request or letter.
    /// </summary>
    [IsoId("_LdpF9W49EeiU9cctagi5ow")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation3> Attachment { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_LdpF9249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
