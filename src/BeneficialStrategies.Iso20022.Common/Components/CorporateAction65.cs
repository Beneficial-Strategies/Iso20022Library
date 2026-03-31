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
[IsoId("_ptF_bzi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action")]
public record CorporateAction65
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_ptF_cTi7Eeydid5dcNPKvg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate70? DateDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_ptF_czi7Eeydid5dcNPKvg")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity13? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_ptF_dTi7Eeydid5dcNPKvg")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat15Choice_? EventStage { get; init; }

    /// <summary>
    /// Indicates whether the message is related to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_ptF_dzi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat21Choice_> AdditionalBusinessProcessIndicator { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of intermediates securities distribution.
    /// </summary>
    [IsoId("_ptF_fzi7Eeydid5dcNPKvg")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_ptF_hzi7Eeydid5dcNPKvg")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat5Choice_? LotteryType { get; init; }
}
