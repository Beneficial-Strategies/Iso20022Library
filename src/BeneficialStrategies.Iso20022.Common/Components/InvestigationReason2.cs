// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Reason2.
/// </summary>
[IsoId("_1OAyUWNqEe6rDI7BtgptxA")]
[DisplayName("Investigation Reason2")]
public partial record InvestigationReason2
{
    #nullable enable

    /// <summary>
    /// Additional Request Data.
    /// </summary>
    [DisplayName("Additional Request Data")]
    [IsoXmlTag("AddtlReqData")]
    public AdditionalRequestData1Choice_? AdditionalRequestData { get; init; } 

    /// <summary>
    /// Enclosed File.
    /// </summary>
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document12> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required InvestigationReason1Choice_ Reason { get; init; } 

    /// <summary>
    /// Reason Sub Type.
    /// </summary>
    [DisplayName("Reason Sub Type")]
    [IsoXmlTag("RsnSubTp")]
    public InvestigationReasonSubType1Choice_? ReasonSubType { get; init; } 

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
    /// Sequence.
    /// </summary>
    [DisplayName("Sequence")]
    [IsoXmlTag("Seq")]
    public IsoMax3Number? Sequence { get; init; } 

    
    #nullable disable
    
}
