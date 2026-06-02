// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
[IsoId("_1jEfcaReEfC9EJoPPbbyNQ")]
[DisplayName("Corporate Action92")]
public record CorporateAction92
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_1t3aMaReEfC9EJoPPbbyNQ")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate86? DateDetails { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_1t3aM6ReEfC9EJoPPbbyNQ")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat14Choice? EventStage { get; init; }

    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_1t3aNaReEfC9EJoPPbbyNQ")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat23Choice> AdditionalBusinessProcessIndicator { get; init; } = [];

    /// <summary>
    /// Specifies the event type of the following event.
    /// </summary>
    [IsoId("_1t3aPaReEfC9EJoPPbbyNQ")]
    [DisplayName("Following Event Type Indicator")]
    [IsoXmlTag("FllwngEvtTpInd")]
    public IntermediateSecuritiesDistributionTypeFormat19Choice? FollowingEventTypeIndicator { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_1t3aP6ReEfC9EJoPPbbyNQ")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice? LotteryType { get; init; }
}
