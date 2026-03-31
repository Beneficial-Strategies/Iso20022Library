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
[IsoId("_MZb3LUEEEeWVgfuHGaKtRQ")]
[DisplayName("Corporate Action")]
public record CorporateAction33
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_MlVlAUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate49? DateDetails { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_MlVlA0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat14Choice_? EventStage { get; init; }

    /// <summary>
    /// Indicates that the additional business process relates to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_8GosNGXJEeWht50_j0HXAQ")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public AdditionalBusinessProcessFormat11Choice_? AdditionalBusinessProcessIndicator { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_MlVlBUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice_? LotteryType { get; init; }
}
