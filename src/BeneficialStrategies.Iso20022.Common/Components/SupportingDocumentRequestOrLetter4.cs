// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supporting Document Request Or Letter4.
/// </summary>
[IsoId("_44LMsTEyEe6g-ffJsqGiSA")]
[DisplayName("Supporting Document Request Or Letter4")]
public record SupportingDocumentRequestOrLetter4
{
    /// <summary>
    /// Attachment.
    /// </summary>
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax1025Text? Description { get; init; }

    /// <summary>
    /// Due Date.
    /// </summary>
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Original References.
    /// </summary>
    [DisplayName("Original References")]
    [IsoXmlTag("OrgnlRefs")]
    public ValueList<OriginalMessage6> OriginalReferences { get; init; } = [];

    /// <summary>
    /// Receiver.
    /// </summary>
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public Party50Choice_? Receiver { get; init; }

    /// <summary>
    /// Request Or Letter Identification.
    /// </summary>
    [DisplayName("Request Or Letter Identification")]
    [IsoXmlTag("ReqOrLttrId")]
    public required IsoMax35Text RequestOrLetterIdentification { get; init; }

    /// <summary>
    /// Response Required.
    /// </summary>
    [DisplayName("Response Required")]
    [IsoXmlTag("RspnReqrd")]
    public required IsoTrueFalseIndicator ResponseRequired { get; init; }

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public Party50Choice_? Sender { get; init; }

    /// <summary>
    /// Subject.
    /// </summary>
    [DisplayName("Subject")]
    [IsoXmlTag("Sbjt")]
    public required IsoMax140Text Subject { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required SupportLetterType1Choice_ Type { get; init; }
}
