// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Data2.
/// </summary>
[IsoId("_ZmtpsWNrEe6rDI7BtgptxA")]
[DisplayName("Investigation Data2")]
public record InvestigationData2
{
    /// <summary>
    /// Enclosed File.
    /// </summary>
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Original Investigation Reason.
    /// </summary>
    [DisplayName("Original Investigation Reason")]
    [IsoXmlTag("OrgnlInvstgtnRsn")]
    public InvestigationReason1Choice_? OriginalInvestigationReason { get; init; }

    /// <summary>
    /// Original Investigation Reason Sub Type.
    /// </summary>
    [DisplayName("Original Investigation Reason Sub Type")]
    [IsoXmlTag("OrgnlInvstgtnRsnSubTp")]
    public InvestigationReasonSubType1Choice_? OriginalInvestigationReasonSubType { get; init; }

    /// <summary>
    /// Original Investigation Sequence.
    /// </summary>
    [DisplayName("Original Investigation Sequence")]
    [IsoXmlTag("OrgnlInvstgtnSeq")]
    public IsoMax3Number? OriginalInvestigationSequence { get; init; }

    /// <summary>
    /// Related File Data.
    /// </summary>
    [DisplayName("Related File Data")]
    [IsoXmlTag("RltdFileData")]
    public ValueList<FileData1> RelatedFileData { get; init; } = [];

    /// <summary>
    /// Related Investigation Data.
    /// </summary>
    [DisplayName("Related Investigation Data")]
    [IsoXmlTag("RltdInvstgtnData")]
    public RelatedInvestigationData1? RelatedInvestigationData { get; init; }

    /// <summary>
    /// Response Data.
    /// </summary>
    [DisplayName("Response Data")]
    [IsoXmlTag("RspnData")]
    public required InvestigationDataRecord1Choice_ ResponseData { get; init; }

    /// <summary>
    /// Response Originator.
    /// </summary>
    [DisplayName("Response Originator")]
    [IsoXmlTag("RspnOrgtr")]
    public Party40Choice_? ResponseOriginator { get; init; }
}
