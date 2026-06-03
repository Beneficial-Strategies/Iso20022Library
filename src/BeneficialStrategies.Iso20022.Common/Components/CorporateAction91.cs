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
[IsoId("_IASTkaRdEfC9EJoPPbbyNQ")]
[DisplayName("Corporate Action91")]
public record CorporateAction91
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_IGoMIaRdEfC9EJoPPbbyNQ")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate85? DateDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_IGoMI6RdEfC9EJoPPbbyNQ")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity12? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_IGoMJaRdEfC9EJoPPbbyNQ")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat14Choice_? EventStage { get; init; }

    /// <summary>
    /// Indicates whether the message is related to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_IGoMJ6RdEfC9EJoPPbbyNQ")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat18Choice_> AdditionalBusinessProcessIndicator { get; init; } = [];

    /// <summary>
    /// Specifies the event type of the following event.
    /// </summary>
    [IsoId("_IGoML6RdEfC9EJoPPbbyNQ")]
    [DisplayName("Following Event Type Indicator")]
    [IsoXmlTag("FllwngEvtTpInd")]
    public IntermediateSecuritiesDistributionTypeFormat19Choice_? FollowingEventTypeIndicator { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_IGoMN6RdEfC9EJoPPbbyNQ")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice_? LotteryType { get; init; }
}
