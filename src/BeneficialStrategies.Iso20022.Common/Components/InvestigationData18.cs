// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the detailed information for the investigation response.
/// </summary>
[IsoId("9cb13d85-f189-499e-ae47-75a9c98d16d4")]
[DisplayName("Investigation Data18")]
public record InvestigationData18
{
    /// <summary>
    /// Original investigation sequence as provided in the investigation request.
    /// </summary>
    [IsoId("ffc0f974-339c-48ae-964c-36e424b25921")]
    [DisplayName("Original Investigation Sequence")]
    [IsoXmlTag("OrgnlInvstgtnSeq")]
    public IsoMax3Number? OriginalInvestigationSequence { get; init; }

    /// <summary>
    /// Original investigation reason as provided in the investigation request.
    /// </summary>
    [IsoId("bc9ecd45-906c-4a4d-b943-d3ea54c70f59")]
    [DisplayName("Original Investigation Reason")]
    [IsoXmlTag("OrgnlInvstgtnRsn")]
    public InvestigationReason1Choice_? OriginalInvestigationReason { get; init; }

    /// <summary>
    /// Original investigation reason sub type as provided in the investigation request.
    /// </summary>
    [IsoId("17dc79e6-5a8b-41fc-a004-164f9723bf8a")]
    [DisplayName("Original Investigation Reason Sub Type")]
    [IsoXmlTag("OrgnlInvstgtnRsnSubTp")]
    public InvestigationReasonSubType1Choice_? OriginalInvestigationReasonSubType { get; init; }

    /// <summary>
    /// Response to the investigation, as provided by the responder.
    /// </summary>
    [IsoId("85c8b22f-8c30-48a9-881d-1854c5af04dd")]
    [DisplayName("Response Data")]
    [IsoXmlTag("RspnData")]
    public required InvestigationDataRecord12Choice_ ResponseData { get; init; }

    /// <summary>
    /// Additional information that will be sent separately to the message such as a copy of a passport.
    /// </summary>
    [IsoId("54f8fe15-0e47-40a6-b8fe-c43227e8222a")]
    [DisplayName("Related Investigation Data")]
    [IsoXmlTag("RltdInvstgtnData")]
    public RelatedInvestigationData1? RelatedInvestigationData { get; init; }

    /// <summary>
    /// Document or template enclosed in the message.
    /// </summary>
    [IsoId("8dc301f4-d61a-4d30-a8f6-32e2b756d682")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Details of a document not enclosed in the message that will be sent or made available separately.
    /// </summary>
    [IsoId("34aa4825-a535-46ea-adf1-1fec80834ce4")]
    [DisplayName("Related File Data")]
    [IsoXmlTag("RltdFileData")]
    public ValueList<FileData1> RelatedFileData { get; init; } = [];

    /// <summary>
    /// Identification of the agent or party who has originated the response.
    /// </summary>
    [IsoId("e9a5ac62-365c-44fc-af1a-5a08dfa7ba61")]
    [DisplayName("Response Originator")]
    [IsoXmlTag("RspnOrgtr")]
    public Party40Choice_? ResponseOriginator { get; init; }
}
